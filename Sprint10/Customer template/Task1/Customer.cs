using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10.Customer_template.Task1
{
    class Customer : MailService
    {
        public void Register(string email, string password)
        {
            try
            {
                if (ValidEmail(email))
                {
                    SendEmail(email, "Email title", "Email body");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
