using CommunicationApp.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;

namespace CommunicationApp.Repository
{
    public class MailRepository : IMailRepository
    {
        public void  SendMail(List<Person> ToList, string subject, string body)
        {
            var message = new MailMessage();
            foreach (var person in ToList)
            {
                try {
                    message.To.Add(new MailAddress($"{person.Email}",$"{person.Name}"));
                    message.From = new MailAddress("team8communication@outlook.com", "Kommunikationssystemet");
                    SmtpClient smtp = new SmtpClient();
                    message.Subject = subject;
                    message.Priority = MailPriority.High;
                    message.IsBodyHtml = true;
                    message.Body = body;
                    smtp.Port = 587;
                    smtp.Host = "smtp.live.com";
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential("team8communication@outlook.com", "jonasisthemaster1");
                    smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtp.SendMailAsync(message);
                }
                catch(Exception)
                {
                    // Ignore exception
                }
            }
        }
    }
}