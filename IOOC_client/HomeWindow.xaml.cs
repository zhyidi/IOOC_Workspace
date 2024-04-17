using IOOC_client.source;
using System;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Input;

namespace IOOC_client
{
    /// <summary>
    /// Home.xaml 的交互逻辑
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen; //窗口居中显示
            Initial();
        }
        private void Initial()
        {
            string sql = "sql#select DoctorName from doctor where DoctorID=(select ID from user where User =" + Communication.inputUserId + ")";
            Communication.SendMes(sql);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    doctorname.Content = Communication.receiveMsg;
                    Communication.receiveMsg = null;
                    break;
                }
            }
            Console.WriteLine(DateTime.Now.ToString());
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
         * 页面跳转到登录
         */
       

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
        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

   
        /*
         * 跳转科内会诊
        */
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DepartmentConsultationWindow page_consultation = new DepartmentConsultationWindow();
            this.Close();
            page_consultation.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyCaseWindow myCaseWindow = new MyCaseWindow();
            this.Close();
            myCaseWindow.Show();
        }
        // 跳转病人登记页面
  
 
        // 跳转取材登记页面
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SliceWindow pageSlice = new SliceWindow();
            this.Close();
            pageSlice.Show();
        }

  

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            AboutUsWindow aboutUsWindow = new AboutUsWindow();
            this.Close();
            aboutUsWindow.Show();
        }

 



        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow();
            this.Close();
            loginWindow.Show();
            //退出关闭套接字连接
            Communication.ClientClose();
        }

        private void btnPersonalSettingWindow_Click(object sender, RoutedEventArgs e)
        {
            PersonalSettingWindow personalSettingWindow = new PersonalSettingWindow();
            this.Close();
            personalSettingWindow.Show();
        }

        private void btnPatientRegisterWindow_Click(object sender, RoutedEventArgs e)
        {
            PatientRegisterWindow pagePatientRegister = new PatientRegisterWindow();
            this.Close();
            pagePatientRegister.Show();
        }

        private void btnGetInfoCWindow_Click(object sender, RoutedEventArgs e)
        {
            GetInfoWindow pageGetInfo = new GetInfoWindow();
            this.Close();
            pageGetInfo.Show();
        }

        private void btnSliceWindow_Click(object sender, RoutedEventArgs e)
        {
            SliceWindow pageSlice = new SliceWindow();
            this.Close();
            pageSlice.Show();
        }

        private void btnDepartmentConsultationWindow_Click(object sender, RoutedEventArgs e)
        {
            DepartmentConsultationWindow page_consultation = new DepartmentConsultationWindow();
            this.Close();
            page_consultation.Show();
        }

        private void btnPathologicDiagnosisWindow_Click(object sender, RoutedEventArgs e)
        {
            MyCaseWindow myCaseWindow = new MyCaseWindow();
            this.Close();
            myCaseWindow.Show();
        }

        private void btnUserManageWindow_Click(object sender, RoutedEventArgs e)
        {
            UserManageWindow userManageWindow = new UserManageWindow();
            this.Close();
            userManageWindow.Show();
        }

        private void btnDoctorInformationManageWindow_Click(object sender, RoutedEventArgs e)
        {
            DoctorInformationManageWindow doctorInformationManageWindow = new DoctorInformationManageWindow();
            this.Close();
            doctorInformationManageWindow.Show();
        }

        private void btnAboutUsWindow_Click(object sender, RoutedEventArgs e)
        {
            AboutUsWindow aboutUsWindow = new AboutUsWindow();
            this.Close();
            aboutUsWindow.Show();
        }
    }
}
