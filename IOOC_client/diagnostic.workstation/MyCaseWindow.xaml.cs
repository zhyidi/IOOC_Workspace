using IOOC_client.source;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace IOOC_client
{
    /// <summary>
    /// My_cases.xaml 的交互逻辑
    /// </summary>
    public partial class MyCaseWindow : Window
    {
        DataTable dt;
        public static string patientID;
        public static string PathologyID;
        public static string doctorID;
        public static string type;
        public static string submissionTime;
        public static string status;
        public MyCaseWindow()
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
                    datagridCase.ItemsSource = dt.DefaultView;
                    Communication.receiveMsg = null;
                    break;
                }
            }

        }
        /*
        * 动态展现二级菜单
        */
        private void Take_MouseEnter32(object sender, MouseEventArgs e)
        {
            Take32.Height = 240;
        }

        private void Take_MouseLeave32(object sender, MouseEventArgs e)
        {
            Take32.Height = 40;
        }

        /*
       * 动态展现二级菜单
       */
        private void diagnosis_MouseEnter32(object sender, MouseEventArgs e)
        {
            Diagnosis32.Height = 175;
        }

        private void diagnosis_MouseLeave32(object sender, MouseEventArgs e)
        {
            Diagnosis32.Height = 40;
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

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }



        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PatientRegisterWindow pagePatientRegister = new PatientRegisterWindow();
            this.Close();
            pagePatientRegister.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DepartmentConsultationWindow page_applytome = new DepartmentConsultationWindow();
            this.Close();
            page_applytome.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ReportDiagnosisWindow report_Diagnosis = new ReportDiagnosisWindow();
            this.Close();
            report_Diagnosis.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            this.Close();
            homeWindow.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            AboutUsWindow aboutUsWindow = new AboutUsWindow();
            this.Close();
            aboutUsWindow.Show();
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
            UserManageWindow userManageWindow = new UserManageWindow();
            this.Close();
            userManageWindow.Show();

        }
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            PatientInformationManageWindow patientInformationManageWindow = new PatientInformationManageWindow();
            this.Close();
            patientInformationManageWindow.Show();

        }



        private void datepickerEnd_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(datepickerStart.Text.Equals("") && datapickerEnd.Text.Equals("")))
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "Date>'" + datepickerStart.Text + "' and Date<'" + datapickerEnd.Text + "'";
            }
        }

        private void checkboxSliced_Click(object sender, RoutedEventArgs e)
        {


            DataView dv = dt.DefaultView;
            if (checkboxSliced.IsChecked == true)
            {
                dv.RowFilter = "status='" + checkboxSliced.Content + "'";
            }
            else
            {
                dv.RowFilter = "";
            }
        }

        private void checkboxPassed_Click(object sender, RoutedEventArgs e)
        {
            DataView dv = dt.DefaultView;
            if (checkboxPassed.IsChecked == true)
            {
                dv.RowFilter = "status='" + checkboxPassed.Content + "'";
            }
            else
            {
                dv.RowFilter = "";
            }
        }

        private void checkboxReturned_Click(object sender, RoutedEventArgs e)
        {
            DataView dv = dt.DefaultView;
            if (checkboxReturned.IsChecked == true)
            {
                dv.RowFilter = "status='" + checkboxReturned.Content + "'";
            }
            else
            {
                dv.RowFilter = "";
            }
        }

        private void datagridCase_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PathologyID = dt.Rows[datagridCase.SelectedIndex][0].ToString();
            doctorID = dt.Rows[datagridCase.SelectedIndex][1].ToString();
            patientID = dt.Rows[datagridCase.SelectedIndex][2].ToString();
            type = dt.Rows[datagridCase.SelectedIndex][3].ToString();
            submissionTime = dt.Rows[datagridCase.SelectedIndex][4].ToString();
            status = dt.Rows[datagridCase.SelectedIndex][6].ToString();
            if (status.Equals("已通过"))
            {
                ReportDiagnosisWindow report_Diagnosis = new ReportDiagnosisWindow();
                this.Close();
                report_Diagnosis.Show();
            }
            else if (status.Equals("已切片"))
            {
                ImageViewWindow imageViewWindow = new ImageViewWindow();
                this.Close();
                imageViewWindow.Show();
            }

        }
    }
}
