using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Net.Sockets;
using IOOC_client.source;
using Newtonsoft.Json;
using System.Data;
using System;
using System.Windows.Media.Imaging;
using System.IO;

namespace IOOC_client
{
    /// <summary>
    /// Report_diagnosis.xaml 的交互逻辑
    /// </summary>
    public partial class ReportDiagnosisWindow : Window
    {
        DataTable dt;
        public ReportDiagnosisWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen; //窗口居中显示
            Initial();
        }

        private void Initial()
        {
            //若病人状态为“已通过”，只能查看，不能修改
            if (MyCaseWindow.status.Equals("已通过"))
            {
                Communication.SendMes("sql#select Eye from diagnosis where PatientID = " + MyCaseWindow.PathologyID);
                while (true)
                {
                    if (Communication.receiveMsg != null)
                    {
                        textboxEyes.Text = Communication.receiveMsg;
                        textboxEyes.IsReadOnly = true;
                        Communication.receiveMsg = null;
                        break;
                    }
                }

                Communication.SendMes("sql#select View from diagnosis where PatientID = " + MyCaseWindow.PathologyID);
                while (true)
                {
                    if (Communication.receiveMsg != null)
                    {
                        textboxDiagnosticOpinion.Text = Communication.receiveMsg;
                        textboxDiagnosticOpinion.IsReadOnly = true;
                        Communication.receiveMsg = null;
                        break;
                    }
                }
                textboxDiagnosticOpinion.IsReadOnly = true;
                textboxEyes.IsReadOnly = true;
                datagridTemplate.IsReadOnly = true;
            }
            string sql = "select_table#select * from template";
            Communication.SendMes(sql);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    //反序列化操作
                    dt = JsonConvert.DeserializeObject<DataTable>(Communication.receiveMsg);
                    datagridTemplate.ItemsSource = dt.DefaultView;
                    Communication.receiveMsg = null;
                    break;
                }
            }
            labelPatientID.Content = MyCaseWindow.patientID;
            labelType.Content = MyCaseWindow.type;
            labelSubmissionTime.Content = MyCaseWindow.submissionTime;

            Communication.SendMes("sql#select Name from patient where PatientID = " + MyCaseWindow.PathologyID);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    labelPatientName.Content = Communication.receiveMsg;
                    Communication.receiveMsg = null;
                    break;
                }
            }

            Communication.SendMes("sql#select Sex from patient where PatientID = " + MyCaseWindow.PathologyID);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    labelPatientGender.Content = Communication.receiveMsg;
                    Communication.receiveMsg = null;
                    break;
                }
            }

            Communication.SendMes("sql#select Age from patient where PatientID = " + MyCaseWindow.PathologyID);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    labelPatientAge.Content = Communication.receiveMsg;
                    Communication.receiveMsg = null;
                    break;
                }
            }

            Communication.SendMes("sql#select DoctorName from doctor where DoctorID = " + MyCaseWindow.doctorID);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    labelSubmissionDoctorName.Content = Communication.receiveMsg;
                    Communication.receiveMsg = null;
                    break;
                }
            }

            Communication.SendMes("sql#select DepartmentName from doctor,department where doctor.DepartmentID = department.DepartmentID and DoctorID = " + MyCaseWindow.doctorID);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    labelDepartment.Content = Communication.receiveMsg;
                    Communication.receiveMsg = null;
                    break;
                }
            }
            labelReportDate.Content = DateTime.Now.ToString();
            Communication.SendMes("sql#select DoctorName from doctor,user where doctor.DoctorID = user.ID and DoctorID = " + MyCaseWindow.doctorID);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    labelReportDoctorName.Content = Communication.receiveMsg;
                    Communication.receiveMsg = null;
                    break;
                }
            }

            sql = "sql#select Eyes from take where PatientID=" + MyCaseWindow.PathologyID;
            Communication.SendMes(sql);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    textboxEyes.Text = Communication.receiveMsg;
                    Communication.receiveMsg = null;
                    break;
                }
            }

            sql = "select_image#select Microscopy from diagnosis where PatientID=" + MyCaseWindow.PathologyID;
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
        private void ScrollBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ImageViewWindow image_View = new ImageViewWindow();
            this.Close();
            image_View.Show();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HomeWindow home = new HomeWindow();
            this.Close();
            home.Show();
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
            AboutUsWindow aboutUsWindow = new AboutUsWindow();
            this.Close();
            aboutUsWindow.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            PatientRegisterWindow pagePatientRegister = new PatientRegisterWindow();
            this.Close();
            pagePatientRegister.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            GetInfoWindow pageGetInfo = new GetInfoWindow();
            this.Close();
            pageGetInfo.Show();
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

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            MyCaseWindow my_Cases = new MyCaseWindow();
            this.Close();
            my_Cases.Show();
        }

        private void datagridTemplate_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            textboxDiagnosticOpinion.Text = dt.Rows[datagridTemplate.SelectedIndex][2].ToString();
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

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            ImageViewWindow imageViewWindow = new ImageViewWindow();
            this.Close();
            imageViewWindow.Show();
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("是否确认保存？", "确认信息", MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                string sql = "sql#update diagnosis set Eye='" + textboxEyes.Text + "',View='" + textboxDiagnosticOpinion.Text + "' ,Report_Doctor = "+ MyCaseWindow.doctorID +", Date = '"+ DateTime.Now.ToString() +"',Check_State='"+MyCaseWindow.type+ "' where PatientID =" + MyCaseWindow.PathologyID;
                Communication.SendMes(sql);
                sql = "sql#update pathology_register set status = '已通过' where PathologyID="+MyCaseWindow.PathologyID;
                Communication.SendMes(sql);
            }
        }
    }
}
