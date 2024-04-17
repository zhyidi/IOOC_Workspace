using IOOC_client.source;
using System;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace IOOC_client
{
    /// <summary>
    /// Retrieve_passwd.xaml 的交互逻辑
    /// </summary>
    public partial class Retrieve_passwd : Window
    {
        public Retrieve_passwd()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ID_text.Text.Equals("") || mail_text.Text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("请填写账号和邮箱", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            Communication.inputUserId = ID_text.Text;
            Communication.SendMes("verify_first#" + ID_text.Text + "#" + mail_text.Text);
            verify_btn.IsEnabled = false;//禁用按钮
            verify_btn.Opacity = 0.5;
            Thread th = new Thread(ReceiveMsg)
            {
                IsBackground = true
            };
            th.Start();
        }

        private void ReceiveMsg()
        {
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    if (Communication.receiveMsg.Equals("mail_ID_success"))
                    {
                        this.Dispatcher.Invoke(new Action(() =>
                        {
                            System.Windows.Forms.MessageBox.Show("验证码已发送至" + mail_text.Text, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                        }
                        ));
                    }
                    else
                    {
                        this.Dispatcher.Invoke(new Action(() =>
                        {
                            System.Windows.Forms.MessageBox.Show("输入的账号和邮箱不对应\n请重新输入", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        }
                        ));
                    }
                    verify_btn.Dispatcher.Invoke(new Action(() =>
                    {
                        verify_btn.IsEnabled = true;//激活按钮
                        verify_btn.Opacity = 1;
                    }));
                    Communication.receiveMsg = null;
                    break;
                }
            }
            Thread.CurrentThread.Abort();
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (ID_text.Text.Equals("") || mail_text.Text.Equals("") || verify_code.Text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("请全部填写完整", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            Communication.SendMes("verify_second#" + ID_text.Text + "#" + verify_code.Text);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    if (Communication.receiveMsg.Equals("verify_yes"))
                    {
                        reset_Password reset = new reset_Password();
                        this.Close();
                        reset.Show();
                    }
                    else if (Communication.receiveMsg.Equals("no_code"))
                    {
                        System.Windows.Forms.MessageBox.Show("请重新获取验证码\n获取验证码和提交时请保持账号栏一致", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("验证码错误", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    }
                    Communication.receiveMsg = null;
                    break;
                }
            }
        }
    }
}
