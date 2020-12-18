using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10.Customer_template.Task1
{
    class MailService
    {
        public bool ValidEmail(string email)
        {
            return email.Contains("@");
        }

        public void SendEmail(string mail, string emailTitle, string emailBody)
        {
            Console.WriteLine(string.Format("Mail:{0}, Title:{1}, Body:{2}", mail, emailTitle, emailBody));
        }
    }
}
