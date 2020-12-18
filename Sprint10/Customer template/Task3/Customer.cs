using System;

namespace Sprint10.Customer_template.Task3
{
    class Customer
    {
        public static void Register(string email, string password)
        {
            try
            {
                var mailService = new MailService(email);
                if (mailService.ValidEmail())
                {
                    mailService.SendNotification();
                    mailService.AddNotificationToDB();
                }

                var smsService = new SmsService();
                smsService.SendNotification();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
