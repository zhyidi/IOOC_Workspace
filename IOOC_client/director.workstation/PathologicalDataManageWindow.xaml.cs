using IOOC_client.source;
using Newtonsoft.Json;
using System.Data;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Input;

namespace IOOC_client
{
    /// <summary>
    /// PathologicalDataManageWindow.xaml 的交互逻辑
    /// </summary>
    public partial class PathologicalDataManageWindow : Window
    {
        DataTable dt1, dt2, dt3;
        public PathologicalDataManageWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Initial();
        }

        private void Initial()
        {
            string sql = "select_table#select * from Pathology_Register";
            Communication.SendMes(sql);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    //反序列化操作
                    dt1 = JsonConvert.DeserializeObject<DataTable>(Communication.receiveMsg);
                    datagrid1.ItemsSource = dt1.DefaultView;
                    Communication.receiveMsg = null;
                    break;
                }
            }
            sql = "select_table#select * from Take";
            Communication.SendMes(sql);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    //反序列化操作
                    dt2 = JsonConvert.DeserializeObject<DataTable>(Communication.receiveMsg);
                    datagrid2.ItemsSource = dt2.DefaultView;
                    Communication.receiveMsg = null;
                    break;
                }
            }
            sql = "select_table#select * from slice";
            Communication.SendMes(sql);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    //反序列化操作
                    dt3 = JsonConvert.DeserializeObject<DataTable>(Communication.receiveMsg);
                    datagrid3.ItemsSource = dt3.DefaultView;
                    Communication.receiveMsg = null;
                    break;
                }
            }
            check1.Items.Add("免疫组化");
            check1.Items.Add("特殊染色检查");
            check1.Items.Add("常规组织检查");
            check1.Items.Add("");
            check2.Items.Add("常规");
            check2.Items.Add("特殊");
            check2.Items.Add("");
            check3.Items.Add("大");
            check3.Items.Add("中");
            check3.Items.Add("小");
            check3.Items.Add("");
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
            PatientInformationManageWindow patientInformationManageWindow = new PatientInformationManageWindow();
            this.Close();
            patientInformationManageWindow.Show();
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
            HomeWindow homeWindow = new HomeWindow();
            this.Close();
            homeWindow.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            DepartmentInformationManageWindow departmentInformationManageWindow = new DepartmentInformationManageWindow();
            this.Close();
            departmentInformationManageWindow.Show();

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            DiagnosticReportManageWindow diagnosticReportManageWindow = new DiagnosticReportManageWindow();
            this.Close();
            diagnosticReportManageWindow.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MyCaseWindow myCaseWindow = new MyCaseWindow();
            this.Close();
            myCaseWindow.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            GetInfoWindow pageGetInfo = new GetInfoWindow();
            this.Close();
            pageGetInfo.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            SliceWindow pageSlice = new SliceWindow();
            this.Close();
            pageSlice.Show();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            DepartmentConsultationWindow page_consultation = new DepartmentConsultationWindow();
            this.Close();
            page_consultation.Show();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            MyCaseWindow myCaseWindow = new MyCaseWindow();
            this.Close();
            myCaseWindow.Show();
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            AboutUsWindow aboutUsWindow = new AboutUsWindow();
            this.Close();
            aboutUsWindow.Show();
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            int cnt = 0;
            string fifter = "";
            if (!text1.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "PathologyID=" + text1.Text;
                cnt++;
            }
            if (!text2.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "DoctorID=" + text2.Text;
                cnt++;
            }
            if (!text3.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "PatientID=" + text3.Text;
            }
            if (!check1.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "Type='" + check1.Text + "'";
            }

            DataView dv = dt1.DefaultView;
            if (fifter.Equals(""))
            {
                dv.RowFilter = "";
            }
            else
            {
                dv.RowFilter = fifter;
            }
            //查完清空
            text1.Text = ""; text2.Text = ""; text3.Text = "";
            check1.Text = "";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            int cnt = 0;
            string fifter = "";
            if (!text7.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "PatientID=" + text7.Text;
                cnt++;
            }
            if (!text8.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "Bao_DoctorID='" + text8.Text + "'";
                cnt++;
            }
            if (!text9.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "Slice_Doctor='" + text9.Text + "'";
            }
            if (!text10.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "Wax_block='" + text10.Text + "'";
            }
            if (!check2.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "Bao_type='" + check2.Text + "'";
            }
            if (!check3.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "Type='" + check3.Text + "'";
            }

            DataView dv = dt3.DefaultView;
            if (fifter.Equals(""))
            {
                dv.RowFilter = "";
            }
            else
            {
                dv.RowFilter = fifter;
            }
            //查完清空
            text7.Text = ""; text8.Text = ""; text9.Text = "";
            text10.Text = "";check2.Text = ""; check3.Text = "";
        }

        private void DatePicker_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (!(date1.ToString().Equals("") && date2.ToString().Equals("")))
            {
                DataView dv = dt1.DefaultView;
                dv.RowFilter = "Date>'" + date1.ToString() + "' And Date<'" + date2.ToString() + "'";
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            int cnt = 0;
            string fifter = "";
            if (!text4.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "PatientID=" + text4.Text;
                cnt++;
            }
            if (!text5.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "Location='" + text5.Text + "'";
                cnt++;
            }
            if (!text6.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "Place='" + text6.Text + "'";
            }

            DataView dv = dt2.DefaultView;
            if (fifter.Equals(""))
            {
                dv.RowFilter = "";
            }
            else
            {
                dv.RowFilter = fifter;
            }
            //查完清空
            text4.Text = ""; text5.Text = ""; text6.Text = "";
        }

        private void date4_SelectedDateChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (!(date3.ToString().Equals("") && date4.ToString().Equals("")))
            {
                DataView dv = dt2.DefaultView;
                dv.RowFilter = "Date>'" + date3.ToString() + "' And Date<'" + date4.ToString() + "'";
            }
        }
    }
}
