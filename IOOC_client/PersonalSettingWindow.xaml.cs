using IOOC_client.source;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace IOOC_client
{
    /// <summary>
    /// PersonalSettingWindow.xaml 的交互逻辑
    /// </summary>
    public partial class PersonalSettingWindow : Window
    {
        public PersonalSettingWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Initial();
        }

        private void Initial()
        {
            textboxUserId.Text = Communication.inputUserId;
            Communication.SendMes("sql#select Password from user where User = '" + Communication.inputUserId + "'");
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    textboxPassword.Text = Communication.receiveMsg;
                    Communication.receiveMsg = null;
                    break;
                }
            }
            Communication.SendMes("sql#select DoctorName from user,doctor where User.ID = doctor.DoctorID and User = '" + Communication.inputUserId + "'");
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    textboxUserName.Text = Communication.receiveMsg;
                    Communication.receiveMsg = null;
                    break;
                }
            }
            Communication.SendMes("sql#select Sex from user,doctor where User.ID = doctor.DoctorID and User = '" + Communication.inputUserId + "'");
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    textboxUserGender.Text = Communication.receiveMsg;
                    Communication.receiveMsg = null;
                    break;
                }
            }

            Communication.SendMes("sql#select ID from user where User = '" + Communication.inputUserId + "'");
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    textboxDoctorId.Text = Communication.receiveMsg;
                    Communication.receiveMsg = null;
                    break;
                }
            }
            Communication.SendMes("sql#select department.DepartmentName from user,doctor,department where department.DepartmentID = doctor.DepartmentID and User.ID = doctor.DoctorID and User = '" + Communication.inputUserId + "'");
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    textboxUserDepartment.Text = Communication.receiveMsg;
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






        private void btnHome_Click(object sender, RoutedEventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            this.Close();
            homeWindow.Show();
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

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {

            if (MessageBox.Show("是否确认保存？", "确认信息", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                Communication.SendMes("sql#update user set Password ='" + textboxPassword.Text + "' where User ='" + Communication.inputUserId+"'");
                textboxPassword.IsReadOnly = true;
                textboxPassword.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFD9D9D9"));
            }

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            textboxPassword.IsReadOnly = false;
            textboxPassword.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFFFF"));
        }

        private void btnHome1_Click(object sender, RoutedEventArgs e)
        {
            HomeWindow homeWindow = new HomeWindow();
            this.Close();
            homeWindow.Show();
        }

        private void btnGetInfoWindow_Click(object sender, RoutedEventArgs e)
        {
            GetInfoWindow getInfoWindow = new GetInfoWindow();
            this.Close();
            getInfoWindow.Show();
        }
    }
}
