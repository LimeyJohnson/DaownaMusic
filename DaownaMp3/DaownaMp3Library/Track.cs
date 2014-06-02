using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
namespace DaownaMp3Library
{
    [DataContract]
    public class Track
    {
        public int TrackId
        {
            get;
            set;
        }
        public List<PlayList> Playlists
        {
            get;
            set;
        }
        [DataMember]
        public string SongName
        {
            get;
            set;
        }
        [DataMember]
        public string Artist
        {
            get;
            set;
        }
        public string Album
        {
            get;
            set;
        }

        public int UserID
        {
            get;
            set;
        }

        [ForeignKey("UserID")]
        public User User
        {
            get;
            set;
        }

        [DataMember]
        public string BlobURL
        {
            get;
            set;
        }
    }
}