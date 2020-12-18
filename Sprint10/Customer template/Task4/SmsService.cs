using Sprint10.Customer_template.Task3;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10.Customer_template.Task4
{
    class SmsService : INotification
    {

        string Number { get; set; }
        string SmsText { get; set; }
        public SmsService()
        {
            Number = "111 111 111";
            SmsText = "User successfully registered...";
        }
        public  void SendNotification()
        {
            Console.WriteLine(string.Format("Number:{0}, Message:{1}", Number, SmsText));
        }
    }
}
