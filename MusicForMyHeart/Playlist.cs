using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicForMyHeart
{
    class Playlist
    {
        private int playlistid;

        public int PlaylistID
        {
            get { return playlistid; }
            set { playlistid = value; }
        }

        private string playlistname;

        public string PlaylistName
        {
            get { return playlistname; }
            set { playlistname = value; }
        }

        private int userid;

        public int UserID
        {
            get { return userid; }
            set { userid = value; }
        }

        public List<SongData> SongsInPlaylist { get; set; }

        public Playlist(int pid, int uid, string pname, List<SongData> list)
        {
            PlaylistID = pid;
            UserID = uid;
            PlaylistName = pname;
            SongsInPlaylist = list;
        }
    }
}
