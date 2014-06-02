using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DaownaMp3Library
{
    public class User
    {
        public int ID
        {
           get; set;
        }
        public string UserName
        {
            get;
            set;
        }
        public DateTime Date
        {
            get;
            set;
        }
        public bool Active
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public List<PlayList> PlayLists
        {
            get;
            set;
        }
        public List<Track> Tracks
        {
            get;
            set;
        }

        public bool ValidateEmail(string address)
        {
            try
            {
                MailAddress checkAddress = new MailAddress(address);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
        public bool ChangePassword(string oldPassword, string newPassword)
        {
            return false;
        }
        public bool RemoveFromPlaylistIds(int remove) 
        {
            return false;
        }
        public bool CreateUserPlaylist(string name, bool isPublic)
        {
            return false;
        }
    }
}
