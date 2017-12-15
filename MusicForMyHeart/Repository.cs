using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;

namespace MusicForMyHeart
{
    class Repository : DbContext
    {
        public List<SongData> songlist;
        public List<User> users;
        public List<Playlist> playlists;
        public User currentuser;

        public Repository() : base("localsql")
        {
            Database.SetInitializer<Repository>(new DropCreateDatabaseAlways<Repository>());
            string sqlcommand = "Select * from Person";
            SqlDataReader datar = new SqlCommand(sqlcommand, new SqlConnection(connectionString)).ExecuteReader();
            users = new List<User>();
            users.Add(new User((int)datar["ID_person"], (string)datar["login"], (string)datar["password"]));
            
        } //написать конструктор репозитория, заполняя его данными из БД


    }
}
