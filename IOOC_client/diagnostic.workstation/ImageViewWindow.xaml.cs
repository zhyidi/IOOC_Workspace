using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Net.Sockets;
using IOOC_client.source;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;
using System.Text;

namespace IOOC_client
{
    /// <summary>
    /// Image_view.xaml 的交互逻辑
    /// </summary>
    public partial class ImageViewWindow : Window
    {
        public static string satisfaction;
        public ImageViewWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen; //窗口居中显示
            Initial();
        }
        private void Initial()
        {
            string sql = "select_image#select Microscopy from diagnosis where PatientID=" + MyCaseWindow.PathologyID;
            Communication.SendMes(sql);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    BitmapImage bi = new BitmapImage();
                    bi.BeginInit();
                    bi.StreamSource = new MemoryStream(Communication.buffer);
                    bi.EndInit();
                    Microscopy.Source = bi;
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
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReportDiagnosisWindow report_Diagnosis = new ReportDiagnosisWindow();
            this.Close();
            report_Diagnosis.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DepartmentConsultationWindow department_Consultation = new DepartmentConsultationWindow();
            this.Close();
            department_Consultation.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MyCaseWindow my_Cases = new MyCaseWindow();
            this.Close();
            my_Cases.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            HomeWindow home = new HomeWindow();
            this.Close();
            home.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AboutUsWindow aboutUsWindow = new AboutUsWindow();
            this.Close();
            aboutUsWindow.Show();
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


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            MyCaseWindow myCaseWindow = new MyCaseWindow();
            this.Close();
            myCaseWindow.Show();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("是否确认保存？", "确认信息", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                string sql = "sql#update diagnosis set Satisfaction='" + textboxSatisfaction.Text + "' where PatientID = " + MyCaseWindow.PathologyID;
               // string sql = "sql#insert into diagnosis(Satisfaction) values ('"+ textboxSatisfaction.Text + "'";
                Communication.SendMes(sql);
                ReportDiagnosisWindow report_Diagnosis = new ReportDiagnosisWindow();
                this.Close();
                report_Diagnosis.Show();
            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("是否确认打回？", "确认信息", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                string sql = "sql#insert into take(PatientID,Location,Number,Doctor,Date,Speciman) values (" + MyCaseWindow.patientID + ",'" + textboxSatisfaction.Text + "'," +
                   MyCaseWindow.doctorID + ",'" + DateTime.Now.ToString() + "','" + MyCaseWindow.type + "')";
                Communication.SendMes(sql);
            }
        }
    }
}
