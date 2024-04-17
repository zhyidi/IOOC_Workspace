using IOOC_client.source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IOOC_client
{
    /// <summary>
    /// reset_Password.xaml 的交互逻辑
    /// </summary>
    public partial class reset_Password : Window
    {
        public reset_Password()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (newpasswd.Text.Equals(newpasswdplus.Text))
            {
                Communication.SendMes("set_passwd#" + newpasswd.Text + "#" + Communication.inputUserId);
                System.Windows.Forms.MessageBox.Show("密码修改成功", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("两次输入不一样", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }
    }
}
