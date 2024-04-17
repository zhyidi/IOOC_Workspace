using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

/*
 * name：服务器连接类
 * 功能：与服务器的操作，包括连接，通信，关闭等。
 */
namespace IOOC_client.source
{
    public class Communication
    {
        public static string inputUserId;
        public static Socket client;
        public static string receiveMsg;
        public static byte[] buffer = new byte[1024 * 1024];
        public static int len;
        /*
         * 参数：未连接的套接字
         * 返回：连接成功的套接字
         */

        public static int ClientStart()
        {
            if (client == null || client.Connected == false)
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //IPAddress addr = IPAddress.Parse("47.96.7.245");
                IPAddress addr = IPAddress.Parse("127.0.0.1");
                IPEndPoint endp = new IPEndPoint(addr, 5000);
                try
                {
                    client.Connect(endp);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("连接服务器失败", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
            if (!(client == null || client.Connected == false))
            {
                Thread th = new Thread(ReceiveMsg)
                {
                    IsBackground = true
                };
                th.Start();
                return 1;
            }
            return 0;
        }

        /*
         * 功能：向服务器发送信息
         * 参数：（已连接的套接字，要发送的字符串）
         */
        public static void SendMes(String str)
        {
            if (client == null || client.Connected == false)
            {
                //重新连接
                ClientStart();
            }
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(str);
                client.Send(buffer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
         * 功能：向服务器发送信息(字节类型)
         * 参数：（已连接的套接字，要发送的字节数组）
         */
        public static void SendMes_byte(byte[] buffer)
        {
            if (client == null || client.Connected == false)
            {
                //重新连接
                ClientStart();
            }
            try
            {
                client.Send(buffer);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*
         * 功能：接收服务器的信息
         * 参数：SQL
         */
        private static void ReceiveMsg()
        {
            while (true)
            {
                try
                {
                    len = client.Receive(buffer);
                    receiveMsg = Encoding.UTF8.GetString(buffer, 0, len);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    break;
                }
            }
            Thread.CurrentThread.Abort();
        }

        /*
         * 功能：退出登录
         */
        public static void ClientClose()
        {
            inputUserId = "";
            client.Shutdown(SocketShutdown.Both);
            client.Close();
            receiveMsg = null;
        }

    }
}
