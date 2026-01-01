using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsoleBase.Models;

namespace GameConsoleBase.DB
{
    internal class GameDB
    {

        private static List<User> users = new List<User>()
        {
            new User("Itay K","itayk","alonhomo")
        };

        public static bool RegisterUser(User user)
        {
            if(user == null) return false;
            if(users.Any(u=>u.UserName == user.UserName)) return false;
            users.Add(user);
            return true;
        }


    }
}
