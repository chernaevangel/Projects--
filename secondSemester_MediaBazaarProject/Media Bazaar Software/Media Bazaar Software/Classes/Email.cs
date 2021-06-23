using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Media_Bazaar_Software.Classes
{
    public class Email
    {
        private static int port = 587;
        private static string smtp = "smtp.gmail.com";
        private NetworkCredential login;
        private SmtpClient client;
        private MailMessage msg;
        public Email(string send, string email, string password, string fName)
        {
            login = new NetworkCredential("mediabazaarofficial", "mediabazaar123");
            client = new SmtpClient(smtp);
            client.Port = port;
            client.EnableSsl = true;
            client.Credentials = login;
            msg = new MailMessage { From = new MailAddress("mediabazaarofficial@gmail.com", "Media Bazaar Team", Encoding.UTF8) };
            msg.To.Add(new MailAddress(send));
            msg.Subject = "Welcome To Media Bazaar!";
            msg.Body = $"Hello {fName}! Welcome to Media Bazaar. Below you will find your new email and password which you can use to log in to our website and in store application. Please remember to change your password once you log in for the first time! \n \n Email: {email} \n Password: {password}";
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            string token = "Sending...";
            client.SendAsync(msg, token);
        }
    }
}
