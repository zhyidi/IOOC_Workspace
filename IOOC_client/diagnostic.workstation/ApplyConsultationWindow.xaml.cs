using IOOC_client.source;
using System;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Input;

namespace IOOC_client
{
    /// <summary>
    /// ApplyConsultationWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ApplyConsultationWindow : Window
    {

        public ApplyConsultationWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            initial();
        }

        public void initial()
        {
            Communication.SendMes("sql#select DepartmentName from department");

            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    Array ans;
                    ans = Communication.receiveMsg.Split(' ');
                    foreach (string i in ans)
                    {
                        comboboxApplyDepartment.Items.Add(i);
                    }
                    Communication.receiveMsg = null;
                    break;
                }
            }
        }
        /*
        * 动态展现二级菜单
        */
        private void Take_MouseEnter(object sender, MouseEventArgs e)
        {
            Take.Height = 240;
        }

        private void Take_MouseLeave(object sender, MouseEventArgs e)
        {
            Take.Height = 40;
        }

        /*
       * 动态展现二级菜单
       */
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
            DepartmentConsultationWindow page_apply = new DepartmentConsultationWindow();
            this.Close();
            page_apply.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string doctorId;
            Communication.SendMes("sql#select ID from user where User = '" + Communication.inputUserId + "'");
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    doctorId = Communication.receiveMsg;
                    Communication.receiveMsg = null;
                    break;
                }
            }
            string departmentId;
            Communication.SendMes("sql#select DepartmentID from department where DepartmentName = '" + comboboxApplyDepartment.SelectedItem + "'");
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    departmentId = Communication.receiveMsg;
                    Communication.receiveMsg = null;
                    break;
                }
            }
            string gender = "";
            if (radiobtnMan.IsChecked == true) gender = (string)radiobtnMan.Content;
            if (radiobtnWoman.IsChecked == true) gender = (string)radiobtnWoman.Content;
            if (MessageBox.Show("是否确认保存？", "确认信息", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                Communication.SendMes("sql#insert into group_consultation(PatientName,Sex,CasePresentation," +
                    "SubmissionTime,FromDoctorID,Department,ConsultationPurpose)values( '" +
                    textboxPatientName.Text + "','" + gender + "','" + textboxCasePresentation.Text + "','" + DateTime.Now.ToString() + "'," +
                    doctorId + "," + departmentId + ",'" + textboxConsultationPurpose.Text + "')");
            }
            else
            {

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MyCaseWindow page_case = new MyCaseWindow();
            this.Close();
            page_case.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            this.Close();
            homeWindow.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            AboutUsWindow aboutUsWindow = new AboutUsWindow();
            this.Close();
            aboutUsWindow.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SliceWindow pageSlice = new SliceWindow();
            this.Close();
            pageSlice.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            PatientRegisterWindow pagePatientRegister = new PatientRegisterWindow();
            this.Close();
            pagePatientRegister.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            GetInfoWindow pageGetInfo = new GetInfoWindow();
            this.Close();
            pageGetInfo.Show();
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

        private void textboxPatientName_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }

        private void radiobtnMan_Checked(object sender, RoutedEventArgs e)
        {
            if (radiobtnMan.IsChecked == true) Console.WriteLine(radiobtnMan.Content);
        }

        private void radiobtnWoman_Checked(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(radiobtnWoman.Content);
        }

    }
}
