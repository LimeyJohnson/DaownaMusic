using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaownaMp3Library
{
    public class PlayList
    {

        [Key]
        public int PlaylistID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public User Member
        {
            get;
            set;
        }
        public bool IsPublic
        {
            get;
            set;
        }
        public virtual List<PlayListTracks> PlayListTracks
        {
            get;
            set;
        }
        [NotMapped]
        public List<Track> Tracks
        {
            get;
            set;
        }
    }
    public class PlayListTracks
    {
        [Key, Column(Order=0)]
        public int Order { get; set; }
        [Key, Column(Order = 1)]
        public virtual Track Track{ get; set; }
        [Key, Column(Order = 1)]
        public virtual PlayList Playlist { get; set; }
    }
}
