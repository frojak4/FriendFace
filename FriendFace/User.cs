using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendFace
{
    internal class User
    {
        public string UserName;
        public string Bio;
        public bool LoggedIn;


        public User(string username, string bio, bool loggedin)
        {
            UserName = username;
            Bio = bio;
            LoggedIn = loggedin;
        }

    }
    
}
