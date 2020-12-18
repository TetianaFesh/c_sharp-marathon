using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10.Customer_template.Task2
{
    class MailService : NotificationService
    {
        public string Email { get; set; }
        public string EmailTitle { get; set; }
        public string EmailBody { get; set; }

        public MailService(string email)
        {
            Email = email;
            EmailTitle = "User registration";
            EmailBody = "Body of message...";
        }
        public bool ValidEmail()
        {
            return Email.Contains("@");
        }

        public override void SendNotification()
        {
            Console.WriteLine(string.Format("Mail:{0}, Title:{1}, Body:{2}", Email, EmailTitle, EmailBody));
        }
    }
}
