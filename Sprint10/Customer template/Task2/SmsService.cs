using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10.Customer_template.Task2
{
    class SmsService2 : NotificationService
    {

        string Number { get; set; }
        string SmsText { get; set; }
        public SmsService2()
        {
            Number = "111 111 111";
            SmsText = "User successfully registered...";
        }
        public override void SendNotification()
        {
            Console.WriteLine(string.Format("Number:{0}, Message:{1}", Number, SmsText));
        }
    }
}
