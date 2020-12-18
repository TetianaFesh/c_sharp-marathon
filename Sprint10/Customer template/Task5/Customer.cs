using Sprint10.Customer_template.Task4;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10.Customer_template.Task5
{
    class Customer
    {
        public Customer(INotification notififcation)
        {

        }

        public static void Register(string email, string password)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SendNotification(INotification notification)
        {
            notification.SendNotification();
        }
    }
}
