using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IOOC_server.source
{
    class verify
    {
        /*
         * 功能：发送验证邮件
         * 参数：发件人，接收人
         */
        public string send_verify(string emailAcount, string receive_mail)
        {
            string content = null;
            string random_code = null;
            try
            {
                var emailPassword = "rngcfqjinclpcidb";
                random_code = getRandomString(6);
                content = "你正在修改IOOC账户密码，你的验证码是" + random_code + ",如非您本人操作请及时改密！";
                MailMessage message = new MailMessage();
                //设置发件人,发件人需要与设置的邮件发送服务器的邮箱一致
                MailAddress fromAddr = new MailAddress(emailAcount);
                message.From = fromAddr;
                //设置收件人,可添加多个,添加方法与下面的一样
                message.To.Add(receive_mail);
                //设置邮件标题
                message.Subject = "IOOC_重置密码";
                //设置邮件内容
                message.Body = content;

                //设置邮件发送服务器
                SmtpClient client = new SmtpClient("smtp.qq.com", 25);
                //设置发送人的邮箱账号和密码
                client.Credentials = new NetworkCredential(emailAcount, emailPassword);
                //启用ssl,也就是安全发送
                client.EnableSsl = true;
                //发送邮件
                client.Send(message);

            }
            catch (Exception ex)
            {
                //发送失败
            }
            return random_code;
        }

        //按照长度产生字符串
        public string getRandomString(int length)
        {
            String str = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            StringBuilder ans = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int number = random.Next(62);
                ans.Append(str[number]);
            }
            return ans.ToString();
        }
    }
}
