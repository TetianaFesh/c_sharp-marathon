using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint10.Part2.Task2
{
    class MailSender : IMailSender
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public void SendEmail(string mailMessage)
        {
            Console.WriteLine("Sending Email: {0}", mailMessage);
            // Code for getting Email setting and send invoice mail

        }
    }
}
