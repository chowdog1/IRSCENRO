using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Inspection_Report
{
    public static class EmailHelper
    {
        public static void SendRequestEmail(string name, string department, string email, string reason)
        {
            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("cenroinspection@gmail.com", "rxzp xmej glxu siqi");
                smtpClient.EnableSsl = true;

                MailMessage mailMessage = new MailMessage
                {
                    From = new MailAddress("cenroinspection@gmail.com"),
                    Subject = "[NOTICE] New Login Request",
                    Body = $"Name: {name}\nDepartment: {department}\nEmail: {email}\nReason: {reason}",
                };

                mailMessage.To.Add("gatdulanerikalloren@gmail.com");
                smtpClient.Send(mailMessage);

            }
        }
    }
}
