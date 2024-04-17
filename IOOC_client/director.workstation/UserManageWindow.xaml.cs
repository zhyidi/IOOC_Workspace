using System.Windows;
using System.Windows.Input;
using System.Net.Sockets;
using IOOC_client.source;
using Newtonsoft.Json;
using System.Data;

namespace IOOC_client
{
    /// <summary>
    /// UserManageWindow.xaml 的交互逻辑
    /// </summary>
    public partial class UserManageWindow : Window
    {
        public UserManageWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen; //窗口居中显示
            Initial();
        }

        private void Initial()
        {
            string sql = "select_table#select * from user";
            Communication.SendMes(sql);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    //反序列化操作
                    DataTable dt = JsonConvert.DeserializeObject<DataTable>(Communication.receiveMsg);
                    datagrid1.ItemsSource = dt.DefaultView;
                    Communication.receiveMsg = null;
                    break;
                }
            }
        }


        private void Take_MouseEnter(object sender, MouseEventArgs e)
        {
            Take.Height = 240;
        }

        private void Take_MouseLeave(object sender, MouseEventArgs e)
        {
            Take.Height = 40;
        }
        private void diagnosis_MouseEnter(object sender, MouseEventArgs e)
        {
            diagnosis.Height = 175;
        }

        private void diagnosis_MouseLeave(object sender, MouseEventArgs e)
        {
            diagnosis.Height = 40;
        }
        private void director_MouseEnter(object sender, MouseEventArgs e)
        {
            director.Height = 175;
        }

        private void director_MouseLeave(object sender, MouseEventArgs e)
        {
            director.Height = 40;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            this.Close();
            homeWindow.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserManageWindow userManageWindow = new UserManageWindow();
            this.Close();
            userManageWindow.Show();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PatientInformationManageWindow patientInformationManageWindow = new PatientInformationManageWindow();
            this.Close();
            patientInformationManageWindow.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MyCaseWindow myCaseWindow = new MyCaseWindow();
            this.Close();
            myCaseWindow.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            GetInfoWindow pageGetInfo = new GetInfoWindow();
            this.Close();
            pageGetInfo.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SliceWindow pageSlice = new SliceWindow();
            this.Close();
            pageSlice.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            DepartmentConsultationWindow page_consultation = new DepartmentConsultationWindow();
            this.Close();
            page_consultation.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MyCaseWindow myCaseWindow = new MyCaseWindow();
            this.Close();
            myCaseWindow.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            AboutUsWindow aboutUsWindow = new AboutUsWindow();
            this.Close();
            aboutUsWindow.Show();
        }


        private void datagrid1_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            //DataRowView mySelectedElement = (DataRowView)datagrid1.SelectedItem;
            //string result0 = mySelectedElement.Row[0].ToString();
            //string result1 = mySelectedElement.Row[1].ToString();
            //string result2 = mySelectedElement.Row[2].ToString();
            //string sql = "sql#update user set Password='" + result1 + "',Authority='" + result2 + "' where User='" + result0 + "'";
            //Communication.SendMes(sql);
        }
    }
}
