using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicForMyHeart
{
    class User
    {
        private int userid;

        public int UserID
        {
            get { return userid; }
            set { userid = value; }
        }

        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public User(int id, string login, string password)
        {
            UserID = id;
            Login = login;
            Password = password;
        }

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
