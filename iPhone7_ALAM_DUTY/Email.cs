using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace iPhone7_ALAM_DUTY
{
    class Email
    {
        public static void sendEmail()
        {
            var fromAddress = new MailAddress("elyanivson@gmail.com", "Elyanivson");
            var toAddress = new MailAddress("eliav.yaniv@gmail.com", "Yaniv Eliav");
            const string fromPassword = "77777777";
            const string subject = "Out of Stock";
            const string body = "still out of stock!!";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                Timeout = 20000
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
        }
    }
}
