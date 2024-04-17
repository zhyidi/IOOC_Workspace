using IOOC_client.source;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Net.Sockets;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;

namespace IOOC_client
{
    /// <summary>
    /// Get_information.xaml 的交互逻辑
    /// </summary>
    public partial class GetInfoWindow : Window
    {
        DataTable dt;
        public GetInfoWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Initial();
        }

        private void Initial()
        {
            string sql = "select_table#select * from take";
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
            check1.Items.Clear();
            sql = "sql#select PathologyID from pathology_register where status='已登记' or status='已打回'";
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
        }

        private void diagnosis_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            diagnosis.Height = 175;
        }

        private void diagnosis_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            diagnosis.Height = 40;
        }

        private void Take_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Take.Height = 240;
        }

        private void Take_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Take.Height = 40;
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
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SliceWindow slicewindow = new SliceWindow();
            this.Close();
            slicewindow.Show();

        }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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

        private void Button_Click_4(object sender, RoutedEventArgs e)
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
            PatientRegisterWindow patientRegisterWindow = new PatientRegisterWindow();
            this.Close();
            patientRegisterWindow.Show();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            SliceWindow sliceWindow = new SliceWindow();
            this.Close();
            sliceWindow.Show();
        }

        private void DengJiButton2_Click(object sender, RoutedEventArgs e)
        {
            if("".Equals(check1.Text) || "".Equals(Local.Text) || "".Equals(number.Text)||"".Equals(Place.Text)|| "".Equals(chuli.Text)|| "".Equals(eye.Text))
            {
                System.Windows.Forms.MessageBox.Show("请填写完整", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }
            string sql = "sql#select ID from user where User ='" + Communication.inputUserId + "'";
            Communication.SendMes(sql);
            while (true)
            {
                if (Communication.receiveMsg != null)
                {
                    sql = "sql#insert into take (PatientID,Location,Number,Doctor,Date,Specimen,Place,Eyes) values (" + check1.SelectedItem + ",'" + Local.Text + "'," + number.Text + "," + Communication.receiveMsg + ",'" + DateTime.Now.ToString() + "','" + chuli.Text + "','" + Place.Text + "','" + eye.Text + "')$sql#update pathology_register set status='已取材' where PathologyID="+ check1.SelectedItem+ "$select_table#select * from take";
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
                    check1.Items.Remove(check1.SelectedItem);
                    Communication.receiveMsg = null;
                    break;
                }
            }
            System.Windows.Forms.MessageBox.Show("登记成功", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            //清空
            Local.Text = "";number.Text = "";Place.Text = "";
            chuli.Text = "";eye.Text = "";
        }

        private void DengJiButton4_Click(object sender, RoutedEventArgs e)
        {
            int cnt = 0;
            string fifter = "";
            //if (!"".Equals(check1.Text))
            //{
            //    fifter += "PatientID='" + check1.SelectedItem + "'";
            //    cnt++;
            //}
            if (!Local.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "Location='" + Local.Text + "'";
                cnt++;
            }
            if (!number.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "Number='" + number.Text + "'";
                cnt++;
            }
            if (!Place.Text.Equals(""))
            {
                if (cnt != 0)
                {
                    fifter += " And ";
                }
                fifter += "Place='" + Place.Text + "'";
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

        private void show_Click(object sender, RoutedEventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "";
        }

        //private void DengJiButton3_Click(object sender, RoutedEventArgs e)
        //{
        //    DataRowView mySelectedElement = (DataRowView)datagrid1.SelectedItem;
        //    string result =mySelectedElement.Row[0].ToString();
        //    string sql = "sql#delete from take where TakeID=" + result;
        //    Communication.SendMes(sql);
        //}
    }
}
