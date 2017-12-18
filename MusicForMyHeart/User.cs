using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicForMyHeart
{
    class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public int UserID { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        //public User(int id, string login, string password)
        //{
        //    UserID = id;
        //    Login = login;
        //    Password = password;
        //}

        public bool UserCheck(string logintocheck, string passwordtocheck)
        {
            if (logintocheck == Login && passwordtocheck == Password)
            {
                return true;
            }
            return false;
        }
    }
  
    
}
