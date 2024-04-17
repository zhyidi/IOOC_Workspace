using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace IOOC_server.source
{
    public class Log
    {
        // 创建StreamWriter 类的实例
        private static StreamWriter streamWriter_operter = new StreamWriter("C:\\IOOC\\Log_Operate.txt", true);
        private static StreamWriter streamWriter_user = new StreamWriter("C:\\IOOC\\Log_user.txt", true);


        //声明两个委托分别把日志输出到屏幕和文档
        public delegate void Operate_Log(string str);
        public delegate void User_Log();
        //定义委托
        public Operate_Log oper_log;
        public User_Log user_log;

        private static TextBox text_statue, text_user;
        private static List<Socket> users;


        public Log() { }
        public Log(TextBox text_statue, TextBox text_user, ref List<Socket> users)
        {
            Log.text_statue = text_statue;
            Log.text_user = text_user;
            Log.users = users;
            oper_log = new Operate_Log(Log.Append_OperateLog);
            user_log = new User_Log(Log.Append_UserLog);
            oper_log += Log.WriteFile_Operate;
            user_log += Log.WriteFile_user;
        }
        /*
         * 功能：显示操作日志
         */
        private static void Append_OperateLog(String str)
        {
            text_statue.Dispatcher.Invoke(new Action(() =>
            {
                text_statue.AppendText(str);
            }
            ));
        }

        /*
         * 功能：显示登陆日志
         */
        private static void Append_UserLog()
        {
            text_user.Dispatcher.Invoke(new Action(() =>
            {
                text_user.Text = "";
            }
                ));
            foreach (Socket tsocket in users)
            {
                text_user.Dispatcher.Invoke(new Action(() =>
                {
                    text_user.AppendText(DateTime.Now.ToString() + "@ip" + tsocket.RemoteEndPoint.ToString() + "\n");
                }
                ));
            }
        }

        /*
         * 功能：将操作日志写入文件
         */
        private static void WriteFile_Operate(string str)
        {
            streamWriter_operter.Write(str);
            streamWriter_operter.Flush();
        }

        /*
         * 功能：将登录日志写入文件
         */
        private static void WriteFile_user()
        {
            foreach (Socket tsocket in users)
            {
                streamWriter_user.Write(DateTime.Now.ToString() + "@ip" + tsocket.RemoteEndPoint.ToString() + "\n");
            }
            streamWriter_user.Flush();
        }
    }
}
