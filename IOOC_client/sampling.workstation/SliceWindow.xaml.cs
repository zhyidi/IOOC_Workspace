using IOOC_client.source;
using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace IOOC_client
{
    /// <summary>
    /// Slice.xaml 的交互逻辑
    /// </summary>
    public partial class SliceWindow : Window
    {
        DataTable dt;
        string path_image;
        public SliceWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Initial();
        }

        private void Initial()
        {
            string sql = "select_table#select * from slice";
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
            sql = "sql#select PathologyID from pathology_register where status='已取材'";
            Communication.SendMes(sql);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    Array ans;
                    ans = Communication.receiveMsg.Split(' ');
                    foreach (string i in ans)
                    {
                        check1.Items.Add(i);
                    }
                    Communication.receiveMsg = null;
                    break;
                }
            }
            sql = "sql#select DoctorName from doctor";
            Communication.SendMes(sql);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    Array ans;
                    ans = Communication.receiveMsg.Split(' ');
                    foreach (string i in ans)
                    {
                        check2.Items.Add(i);
                        check5.Items.Add(i);
                    }
                    Communication.receiveMsg = null;
                    break;
                }
            }
            check3.Items.Add("常规");
            check3.Items.Add("特殊");

            check4.Items.Add("大");
            check4.Items.Add("中");
            check4.Items.Add("小");
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
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PatientRegisterWindow patientregisterwindow = new PatientRegisterWindow();
            this.Close();
            patientregisterwindow.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            GetInfoWindow getinfo = new GetInfoWindow();
            this.Close();
            getinfo.Show();
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

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MyCaseWindow pageMyCase = new MyCaseWindow();
            this.Close();
            pageMyCase.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            UserManageWindow userManageWindow = new UserManageWindow();
            this.Close();
            userManageWindow.Show();
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            PatientInformationManageWindow patientInformationManageWindow = new PatientInformationManageWindow();
            this.Close();
            patientInformationManageWindow.Show();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            PatientRegisterWindow patientRegisterWindow = new PatientRegisterWindow();
            this.Close();
            patientRegisterWindow.Show();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            GetInfoWindow getInfoWindow = new GetInfoWindow();
            this.Close();
            getInfoWindow.Show();
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if ("".Equals(check1.Text) || "".Equals(check2.Text) || "".Equals(check3.Text) || "".Equals(check4.Text) || "".Equals(check5.Text) || "".Equals(date1.Text) || "".Equals(date2.Text) || "".Equals(text1.Text))
            {
                System.Windows.Forms.MessageBox.Show("请填写完整", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            string bao_doctor;
            string slice_doctor;
            string sql = "sql#select DoctorID from doctor where DoctorName='" + check2.Text + "'";
            Communication.SendMes(sql);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    bao_doctor = Communication.receiveMsg;
                    Communication.receiveMsg = null;
                    break;
                }
            }
            sql = "sql#select DoctorID from doctor where DoctorName='" + check5.Text + "'";
            Communication.SendMes(sql);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    slice_doctor = Communication.receiveMsg;
                    Communication.receiveMsg = null;
                    break;
                }
            }

            sql = "sql#insert into slice (PatientID,Wax_block,Bao_DoctorID,Bao_Date,Bao_type,Type,Slice_Doctor,Slice_Date) values (" + check1.SelectedItem + "," + text1.Text + "," + bao_doctor + ",'" + date1.Text + "','" + check3.Text + "','" + check4.Text + "'," + slice_doctor + ",'" + date2.Text + "')$select_table#select * from slice";
            Communication.receiveMsg = null;
            Communication.SendMes(sql);

            //更新表格
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
            System.Windows.Forms.MessageBox.Show("登记成功", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            //清空
            text1.Text = "";
            check2.Text = ""; check3.Text = ""; check4.Text = ""; check5.Text = "";
            date1.Text = ""; date2.Text = "";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            int cnt = 0;
            string fifter = "";
            //if (!"".Equals(check1.Text))
            //{
            //    fifter += "PatientID='" + check1.Text + "'";
            //    cnt++;
            //}
            if (!text1.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "Wax_block='" + text1.Text + "'";
                cnt++;
            }
            if (!check2.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                string bao_doctor;
                string sql = "sql#select DoctorID from doctor where DoctorName='" + check2.Text + "'";
                Communication.SendMes(sql);
                while (true)
                {
                    if (Communication.receiveMsg != null)
                    {
                        bao_doctor = Communication.receiveMsg;
                        Communication.receiveMsg = null;
                        break;
                    }
                }
                fifter += "Bao_DoctorID=" + bao_doctor;
                cnt++;
            }
            if (!check3.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "Bao_type='" + check3.Text + "'";
                cnt++;
            }
            if (!check4.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "Type='" + check4.Text + "'";
                cnt++;
            }
            if (!check5.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                string slice_doctor;
                string sql = "sql#select DoctorID from doctor where DoctorName='" + check5.Text + "'";
                Communication.SendMes(sql);
                while (true)
                {
                    if (Communication.receiveMsg != null)
                    {
                        slice_doctor = Communication.receiveMsg;
                        Communication.receiveMsg = null;
                        break;
                    }
                }
                fifter += "Slice_Doctor=" + slice_doctor;
            }

            DataView dv = dt.DefaultView;
            if (fifter.Equals(""))
            {
                dv.RowFilter = "";
            }
            else
            {
                dv.RowFilter = fifter;
            }
        }

        private void showall_Click(object sender, RoutedEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "";
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\IOOC\\image";
            openFileDialog.Filter = "(*.jpg;*.png)|*.jpg;*.png";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path_image = openFileDialog.FileName;
                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.UriSource = new Uri(path_image);
                bi.EndInit();
                Image1.Source = bi;
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            FileInfo fileInfo = new FileInfo(path_image);
            Communication.SendMes("load_image#" + fileInfo.Length + "#" + check1.Text);
            byte[] buffer1 = new byte[fileInfo.Length];
            using (FileStream loader = fileInfo.OpenRead())
            {
                loader.Read(buffer1, 0, (int)fileInfo.Length);
            }
            Communication.SendMes_byte(buffer1);
            System.Windows.Forms.MessageBox.Show("上传成功", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            string sql = "sql#update pathology_register set status='已切片' where PathologyID=" + check1.SelectedItem;
            Communication.SendMes(sql);
            check1.Items.Remove(check1.SelectedItem);
        }
    }
}
