using IOOC.source;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Media.Imaging;

namespace IOOC_server.source
{
    public class Server
    {
        private Log log;
        private Socket serverSocket = null;
        //创建在线用户列表
        private List<Socket> users;
        //创建二次验证码
        Hashtable code = new Hashtable();
        /*
         * 构造方法
         */
        public Server() { }
        public Server(ref Log log, ref List<Socket> users)
        {
            this.log = log;
            this.users = users;
        }

        public void ServerStart()
        {
            //放置私网ip
            //IPAddress addr = IPAddress.Parse("172.28.154.146");
            IPAddress addr = IPAddress.Parse("127.0.0.1");
            //创建IPEndPoint实例 
            IPEndPoint endp = new IPEndPoint(addr, 5000);
            //创建一个套接字 
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            serverSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            //将所创建的套接字与IPEndPoint绑定 
            serverSocket.Bind(endp);
            //设置套接字为收听模式 
            serverSocket.Listen(100);
            log.oper_log(DateTime.Now.ToString() + "：服务器开始监听！\n");
            //创建监听线程
            Thread thread = new Thread(AcceptInfo)
            {
                IsBackground = true
            };
            thread.Start(serverSocket);
        }

        /*
         * 监听进程:监听客户端的请求连接并开启连接线程
         */
        private void AcceptInfo(object o)
        {
            Socket serverSocket = o as Socket;
            while (true)
            {
                try
                {
                    //创建通信用的Socket
                    Socket tSocket = serverSocket.Accept();
                    string point = tSocket.RemoteEndPoint.ToString();
                    //加入在线用户
                    users.Add(tSocket);
                    log.oper_log(DateTime.Now.ToString() + "@ip:" + point + "连接成功\n");
                    log.user_log();
                    //连接成功创建服务线程
                    Thread mes_thread = new Thread(ReceiveMsg)
                    {
                        IsBackground = true
                    };
                    mes_thread.Start(tSocket);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
        }


        /*
         * 接收客户端的数据并做处理后返回
         */
        private void ReceiveMsg(object o)
        {
            Socket tsocket = o as Socket;
            string point = null;
            while (true)
            {
                try
                {
                    //定义byte数组存放从客户端接收过来的数据
                    byte[] buffer = new byte[1024 * 1024];
                    //将接收过来的数据放到buffer中，并返回实际接受数据的长度
                    int n = tsocket.Receive(buffer);
                    //将字节转换成字符串
                    string words = Encoding.UTF8.GetString(buffer, 0, n);
                    point = tsocket.RemoteEndPoint.ToString();

                    //发送消息
                    if (words != null)
                    {
                        //主动读取空字符串代表客户端DisConnetced
                        if (n == 0)
                        {
                            break;
                        }
                        //记录日志
                        log.oper_log(DateTime.Now.ToString() + "@ip:" + point + ":" + words + "\n");
                        //分割处理数据（粘包问题）
                        string[] data = words.Split('$');
                        foreach (string data_temp in data)
                        {
                            //判断请求类型
                            string[] type = data_temp.Split('#');
                            switch (type[0])
                            {
                                //处理sql
                                case "sql":
                                    string sql_type = type[1].Split(' ')[0];
                                    if (sql_type.Equals("select", StringComparison.OrdinalIgnoreCase))
                                    {
                                        string ans = DBMySql.findValue_string(type[1]);
                                        buffer = Encoding.UTF8.GetBytes(ans);
                                        tsocket.Send(buffer);
                                        log.oper_log("return：" + ans + "to ip:" + point + "\n");
                                    }
                                    else
                                    {
                                        DBMySql.Executevoid(type[1]);
                                        log.oper_log(point + "发来的请求执行成功\n");
                                    }
                                    break;
                                //返回表格类sql
                                case "select_table":
                                    //得到要返回的表格
                                    DataTable dt = DBMySql.findValue_data_table(type[1]);
                                    //表格对象序列化
                                    string json = JsonConvert.SerializeObject(dt);
                                    buffer = Encoding.UTF8.GetBytes(json);
                                    tsocket.Send(buffer);
                                    break;
                                //忘记密码第一步验证
                                case "verify_first":
                                    //查询该账号和邮箱是否对应
                                    string sql1 = "select Mail from user,doctor where user = '" + type[1] + "' and user.ID=doctor.DoctorID";
                                    string mail_sql = DBMySql.findValue_string(sql1);
                                    if (type[2].Equals(mail_sql))
                                    {
                                        //对应正确发送验证码
                                        string verify_code = new verify().send_verify("zhyidi@vip.qq.com", type[2]);
                                        if (!code.ContainsKey(type[1]))
                                        {
                                            code.Add(type[1], verify_code);
                                        }
                                        else
                                        {
                                            code[type[1]] = verify_code;
                                        }
                                        tsocket.Send(Encoding.UTF8.GetBytes("mail_ID_success"));
                                        log.oper_log("return mail_ID_success to ip:" + point + "\n");
                                    }
                                    else
                                    {
                                        tsocket.Send(Encoding.UTF8.GetBytes("mail_ID_fail"));
                                        log.oper_log("return mail_ID_fail to ip:" + point + "\n");
                                    }

                                    break;
                                //忘记密码第二步验证
                                case "verify_second":
                                    //没有验证码
                                    if (!code.ContainsKey(type[1]))
                                    {
                                        tsocket.Send(Encoding.UTF8.GetBytes("no_code"));
                                        log.oper_log("return no_code to ip:" + point + "\n");
                                        break;
                                    }
                                    //验证成功,修改密码
                                    if (code[type[1]].Equals(type[2]))
                                    {
                                        tsocket.Send(Encoding.UTF8.GetBytes("verify_yes"));
                                        log.oper_log("return verify_yes to ip:" + point + "\n");
                                    }
                                    //验证码错误
                                    else
                                    {
                                        tsocket.Send(Encoding.UTF8.GetBytes("verify_no"));
                                        log.oper_log("return verify_no to ip:" + point + "\n");
                                    }
                                    code.Remove(type[1]);
                                    break;
                                //验证成功修改密码
                                case "set_passwd":
                                    string sql2 = "update user set Password = '" + type[1] + "' where User = '" + type[2] + "'";
                                    DBMySql.Executevoid(sql2);
                                    break;
                                case "select_image":
                                    //得到要返回的图像
                                    string lj_image = DBMySql.findValue_string(type[1]);//得到路径
                                    FileInfo fileInfo = new FileInfo(lj_image);
                                    byte[] buffer1 = new byte[fileInfo.Length];
                                    using (FileStream loader = fileInfo.OpenRead())
                                    {
                                        loader.Read(buffer1, 0, (int)fileInfo.Length);
                                    }
                                    tsocket.Send(buffer1);
                                    break;
                                case "load_image":
                                    //type[2]代表病理号，type[1]代表图片字节数组长度
                                    string path_image = "C:\\IOOC\\image\\" + type[2] + ".jpg";
                                    FileStream image_save = File.Create(path_image);
                                    n = tsocket.Receive(buffer);
                                    image_save.Write(buffer, 0, Convert.ToInt32(type[1]) - 1);
                                    image_save.Flush();
                                    image_save.Close();
                                    string sql = "insert into diagnosis (PatientID,Microscopy) values(" + type[2] + ",'" + path_image + "')";
                                    sql = sql.Replace("\\", "\\\\");
                                    DBMySql.Executevoid(sql);
                                    break;
                                default:
                                    break;
                            }

                        }

                    }
                }
                catch (SocketException ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
            log.oper_log("ip:" + point + "客户端已断开\n");
            //关闭套接字
            tsocket.Shutdown(SocketShutdown.Both);
            tsocket.Close();
            //移除在线用户
            users.Remove(tsocket);
            log.user_log();
            Thread.CurrentThread.Abort();
        }

        /*
        * 关闭服务
        */
        public void ServerClose()
        {
            serverSocket.Close();
        }

    }
}
