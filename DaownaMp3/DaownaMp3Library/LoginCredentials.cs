using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace DaownaMp3Library
{
    public class LoginCredentials
    {
        public string Username
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        [Key]
        public int ID
        {
            get;
            set;
        }

        public void Register()
        {
            DateTime now = DateTime.Now;
        }
        public bool Authenticate()
        {
            return false;
        }
        public void EmailLostPassword()
        {
            //TODO move into hidden connection string so that the world can't see our server info
            //MailMessage passwordMessage = new MailMessage(ServerInfo.DaownaMp3EmailAddress, Username, "Password Recovery", "Your password is: " + Password);
            //SmtpClient objsmtp = new SmtpClient("smtp.gmail.com", 587);
            //objsmtp.EnableSsl = true;
            //objsmtp.UseDefaultCredentials = false;
            //objsmtp.Credentials = new NetworkCredential(ServerInfo.DaownaMp3EmailAddress, ServerInfo.DaownaMp3EmailPassword);
            //objsmtp.Send(passwordMessage);
        }
    }
}
