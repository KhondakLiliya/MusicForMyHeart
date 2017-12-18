using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicForMyHeart
{
    class Context : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Playlist> Playlist { get; set; }
        public DbSet<SongData> SongData { get; set; }

        public Context() : base("Data")
        {
           
        }
    }
}
