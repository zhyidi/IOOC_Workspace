using IOOC_server.source;
using System.Windows;
using System;
using System.Net.Sockets;
using System.Collections.Generic;
using IOOC.source;

namespace IOOC_server
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class Server_Home : Window
    {
        private List<Socket> users;
        private Log log;
        private Server server;
        public Server_Home()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            //连接mysql
            DBMySql.Connection();
        }

        private void connection_Click(object sender, RoutedEventArgs e)
        {
            users = new List<Socket>();
            log = new Log(text_statue, text_zaixian, ref users);
            server = new Server(ref log, ref users);
            try
            {
                server.ServerStart();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        /*
         * 关闭服务器的服务
         */
        private void close_connection_Click(object sender, RoutedEventArgs e)
        {
            server.ServerClose();
        }
    }
}
