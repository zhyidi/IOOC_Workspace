using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using IOOC_client.source;

namespace IOOC_client
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        /*
         * 登录跳转到主页
         */
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //创建连接
            int status = Communication.ClientStart();
            if (status == 1)
            {
                //发送SQL
                if (!(textboxUserId.Text.Equals("")))
                {
                    Communication.SendMes("sql#select Password from user where User = '" + textboxUserId.Text + "'");
                    while (true)
                    {
                        if (Communication.receiveMsg != null)
                        {
                            if (Communication.receiveMsg.Equals("!!!"))
                            {
                                System.Windows.Forms.MessageBox.Show("账号不存在", "登录提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                            }
                            else if (Communication.receiveMsg.Equals(Password.Text))
                            {
                                //Communication.inputUserId = Convert.ToInt32(textboxUserId.Text);
                                Communication.inputUserId = textboxUserId.Text;
                                Communication.receiveMsg = null;
                                HomeWindow home = new HomeWindow();
                                this.Close();
                                home.Show();
                            }
                            else
                            {
                                System.Windows.Forms.MessageBox.Show("密码错误", "登录提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                            }
                            Communication.receiveMsg = null;
                            break;
                        }
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("账号不能为空或者服务器未开启", "登录提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                }
            }
            
        }

        /*
         * 功能：忘记密码处理
         */
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Retrieve_passwd retrieve_Passwd = new Retrieve_passwd();
            retrieve_Passwd.Show();
        }

        private void textboxUserId_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
