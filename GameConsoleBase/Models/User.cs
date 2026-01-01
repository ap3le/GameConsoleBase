using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Models
{
    internal class User
    {

        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string name,string username,string password)
        {
            this.Name = name;
            this.UserName = username;
            this.Password = password;
        }


    }
}
