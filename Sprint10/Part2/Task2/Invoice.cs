using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10.Part2.Task2
{
    class Invoice : MailSender
    {
        public long Amount { get; set; }
        public DateTime InvoiceDate { get; set; }
        
        public void Add()
        {
            Console.WriteLine("Adding amount...");
            // Code for adding invoice
            // Once Invoice has been added , send mail 
            string mailMessage = "Your invoice is ready.";
            SendEmail(mailMessage);
        }
        public void Delete()
        {
            Console.WriteLine("Deleting amount...");
            // Code for Delete invoice
        }
         
    }
}
