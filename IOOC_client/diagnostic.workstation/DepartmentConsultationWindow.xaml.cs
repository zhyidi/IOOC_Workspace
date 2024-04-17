using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Net.Sockets;
using IOOC_client.source;
using System;
using System.Data;
using Newtonsoft.Json;

namespace IOOC_client
{
    /// <summary>
    /// Diagnostic_Workstation.xaml 的交互逻辑
    /// </summary>
    public partial class DepartmentConsultationWindow : Window
    {
        DataTable dt;
        public DepartmentConsultationWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            Initial();
        }
        private void Initial()
        {

            string sql = "select_table#select * from group_consultation where Department=(select DepartmentID from user,doctor where doctor.DoctorID=user.ID and user.User='" + Communication.inputUserId + "')";
            Communication.SendMes(sql);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    //反序列化操作
                    dt = JsonConvert.DeserializeObject<DataTable>(Communication.receiveMsg);
                    datagridMyConsultation.ItemsSource = dt.DefaultView;
                    Communication.receiveMsg = null;
                    break;
                }
            }

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PatientRegisterWindow pagePatientRegister = new PatientRegisterWindow();
            this.Close();
            pagePatientRegister.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }


        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        /*
         * 动态展现二级菜单
         */

        private void take_enter(object sender, MouseEventArgs e)
        {
            Take_Copy.Height = 240;
        }

        private void take_leave(object sender, MouseEventArgs e)
        {
            Take_Copy.Height = 40;
        }

        private void diagnose_enter(object sender, MouseEventArgs e)
        {
            Diagnosis.Height = 175;
        }

        private void diagnose_leave(object sender, MouseEventArgs e)
        {
            Diagnosis.Height = 40;
        }
        private void director_MouseEnter(object sender, MouseEventArgs e)
        {
            director.Height = 175;
        }

        private void director_MouseLeave(object sender, MouseEventArgs e)
        {
            director.Height = 40;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ApplyConsultationWindow page_consultation = new ApplyConsultationWindow();
            this.Close();
            page_consultation.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MyCaseWindow page_case = new MyCaseWindow();
            this.Close();
            page_case.Show();
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
            SliceWindow pageSlice = new SliceWindow();
            this.Close();
            pageSlice.Show();
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



        private void textboxPatientName_TextChanged(object sender, TextChangedEventArgs e)
        {
            DataView dv = dt.DefaultView;
            if (textboxPatientName.Text.Equals(""))
            {
                dv.RowFilter = "";
            }
            else
            {
                dv.RowFilter = "PatientName='" + textboxPatientName.Text + "'";
            }
        }

        private void datapickerEnd_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            if (!(datepickerStart.Text.Equals("") && datapickerEnd.Text.Equals("")))
            {
                DataView dv = dt.DefaultView;
                dv.RowFilter = "SubmissionTime>'" + datepickerStart.Text + "' And SubmissionTime<'" + datapickerEnd.Text + "'";
            }
        }
    }
}
