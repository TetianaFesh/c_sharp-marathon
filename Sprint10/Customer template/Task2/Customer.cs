using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10.Customer_template.Task2
{
    class Customer
    {
        public static void Register(string email, string password)
        {
            MailService ms = new MailService(email);
            SmsService2 sms = new SmsService2();
            try
            {
                if (ms.ValidEmail())
                {
                    ms.SendNotification();
                    sms.SendNotification();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
