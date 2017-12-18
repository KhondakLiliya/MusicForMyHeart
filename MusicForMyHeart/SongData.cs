using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicForMyHeart
{
    class SongData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int SongID { get; set; }

        public string SongName { get; set; }
  
        public string SongArtist { get; set; }

        public string SongGenre { get; set; }

        public int SongLength { get; set; }


        //public SongData(string name, string artist, string genre, int time)
        //{
        //    SongName = name;
        //    SongArtist = artist;
        //    SongGenre = genre;
        //    SongLength = time;
        //}

        /*public string TimeOutput() 
        { 
        int mins = SongLength / 60; 
        int secs = SongLength % 60; 
        return mins + ":" + secs; 
        }*/
    }
}
