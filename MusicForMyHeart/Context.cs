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
            //Database.SetInitializer<Repository>(new DropCreateDatabaseAlways<Repository>());
            //string sqlcommand = "Select * from Person";
            //SqlDataReader datar = new SqlCommand(sqlcommand, new SqlConnection(connectionString)).ExecuteReader();
            //users = new List<User>();
            //users.Add(new User((int)datar["ID_person"], (string)datar["login"], (string)datar["password"]));
        }
    }
}
