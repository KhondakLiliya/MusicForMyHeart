using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicForMyHeart
{
    class SongData
    {
        private int songid;

        public int SongID
        {
            get { return songid; }
            set { songid = value; }
        }


        private string songname;

        public string SongName
        {
            get { return songname; }
            set { songname = value; }
        }

        private string songartist;

        public string SongArtist
        {
            get { return songartist; }
            set { songartist = value; }
        }

        private string songgenre;

        public string SongGenre
        {
            get { return songgenre; }
            set { songgenre = value; }
        }

        private int songlength;

        public int SongLength
        {
            get { return songlength; }
            set { songlength = value; }
        }


        public SongData(string name, string artist, string genre, int time)
        {
            SongName = name;
            SongArtist = artist;
            SongGenre = genre;
            SongLength = time;
        }

        /*public string TimeOutput() 
        { 
        int mins = SongLength / 60; 
        int secs = SongLength % 60; 
        return mins + ":" + secs; 
        }*/
    }
}
