using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;

namespace MusicForMyHeart
{
    class Repository 
    {
        
        public void Create (int _UserID, string _Login, string _Password)
        {
            Context qwerty = new Context();
            foreach (var item in qwerty.User)
            {
                if (item.UserID != _UserID) 
                {
                    User one = new User
                    {
                        Login = _Login,
                        Password = _Password,
                        UserID = _UserID
                    };

                    qwerty.User.Add(one);
                    qwerty.SaveChanges();
                }
            }
        }

        //public void Create_Playlist(int _PlayListID, string _PlaylistName, int _UserID)
        //{
        //    Context qwerty = new Context();
        //    foreach (var item in qwerty.User)
        //}

        public void Update (int _UserID, string _Login, string _Password)
        {
            Context qwerty = new Context();
            foreach (var item in qwerty.User)
            {
                if (item.UserID != _UserID)
                {

                }
            }
        }


    }
}
