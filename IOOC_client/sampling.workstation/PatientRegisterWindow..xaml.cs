using IOOC_client.source;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;

namespace IOOC_client
{
    /// <summary>
    /// Patient_register.xaml 的交互逻辑
    /// </summary>
    public partial class PatientRegisterWindow : Window
    {
        DataTable dt;
        public PatientRegisterWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen; //窗口居中显示
            Initial();
        }

        private void Initial()
        {
            string sql = "select_table#select * from pathology_register";
            Communication.SendMes(sql);
            
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    //反序列化操作
                    dt = JsonConvert.DeserializeObject<DataTable>(Communication.receiveMsg);
                    datagrid1.ItemsSource = dt.DefaultView;
                    Communication.receiveMsg = null;
                    break;
                }
            }
            sex.Items.Add("男");
            sex.Items.Add("女");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            GetInfoWindow getinfo = new GetInfoWindow();
            this.Close();
            getinfo.Show();
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SliceWindow slicewindow = new SliceWindow();
            this.Close();
            slicewindow.Show();

        }
        private void Take_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Take.Height = 240;
        }
        private void Take_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Take.Height = 40;
        }
        private void diagnosis_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            diagnosis.Height = 175;
        }

        private void diagnosis_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            diagnosis.Height = 40;
        }

        private void director_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            director.Height = 175;
        }
        private void director_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
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
            AboutUsWindow aboutUsWindow = new AboutUsWindow();
            this.Close();
            aboutUsWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DepartmentConsultationWindow page_consultation = new DepartmentConsultationWindow();
            this.Close();
            page_consultation.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MyCaseWindow pageMyCase = new MyCaseWindow();
            this.Close();
            pageMyCase.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            UserManageWindow userManageWindow = new UserManageWindow();
            this.Close();
            userManageWindow.Show();
        }
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            PatientInformationManageWindow patientInformationManageWindow = new PatientInformationManageWindow();
            this.Close();
            patientInformationManageWindow.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            GetInfoWindow getInfoWindow = new GetInfoWindow();
            this.Close();
            getInfoWindow.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            SliceWindow sliceWindow = new SliceWindow();
            this.Close();
            sliceWindow.Show();
        }

        private void DengJiButton_Click(object sender, RoutedEventArgs e)
        {
            if (text1.Text.Equals("")|| sex.Text.Equals("") || text3.Text.Equals("") || text4.Text.Equals("") || text5.Text.Equals("") || text6.Text.Equals("") || text7.Text.Equals("") || text8.Text.Equals("") || text9.Text.Equals("") || text10.Text.Equals("") || text11.Text.Equals("") || text12.Text.Equals("") || date1.Text.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("请填写完整", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            string sql = "sql#insert into patient(Name,Sex,Age,Nationality,Marriage,Work,Hometown,ID_card,Phone) values ('" + text1.Text + "','" + sex.Text + "'," + text3.Text + ",'" + text4.Text + "','" + text5.Text + "','" + text6.Text + "','" + text7.Text + "','" + text8.Text + "','" + text9.Text + "')";
            Communication.SendMes(sql);
            sql = "sql#select PatientID from patient where Name='" + text1.Text + "'";
            Communication.SendMes(sql);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    sql = "sql#insert into pathology_register(DoctorID,PatientID,Type,Date,pathology_register.`condition`,pathology_register.`status`) values (" + text11.Text + "," + Communication.receiveMsg + ",'" + text10.Text + "','" + date1.ToString() + "','" + text12.Text + "','已登记')$select_table#select * from pathology_register";
                    Communication.SendMes(sql);
                    System.Threading.Thread.Sleep(10);
                    while (true)
                    {
                        if (Communication.receiveMsg != null)
                        {
                            System.Threading.Thread.Sleep(10);
                            //反序列化操作
                            dt = JsonConvert.DeserializeObject<DataTable>(Communication.receiveMsg);
                            datagrid1.ItemsSource = dt.DefaultView;
                            Communication.receiveMsg = null;
                            break;
                        }
                    }
                    Communication.receiveMsg = null;
                    break;
                }
            }
            System.Windows.Forms.MessageBox.Show("登记成功", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
        }

        private void DatePicker_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (!(date2.ToString().Equals("") && date3.ToString().Equals("")))
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "Date>'" + date2.ToString() + "' And Date<'" + date3.ToString() + "'";
            }
        }

        private void text13_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            DataView dv = dt.DefaultView;
            if (text13.Text.Equals(""))
            {
                dv.RowFilter = "";
            }
            else
            {
                dv.RowFilter = "PathologyID=" + text13.Text;
            }
        }
    }
}
