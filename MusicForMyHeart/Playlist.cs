using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicForMyHeart
{
    class Playlist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlaylistID { get; set; }

        public string PlaylistName { get; set; }

        public int UserID { get; set; }

        public List<SongData> SongsInPlaylist { get; set; }

        //public Playlist(int pid, int uid, string pname, List<SongData> list)
        //{
        //    PlaylistID = pid;
        //    UserID = uid;
        //    PlaylistName = pname;
        //    SongsInPlaylist = list;
        //}
    }
}
