using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsoleBase.BaseClass;

namespace GameConsoleBase.Pages
{
    internal class RegisterScreen:BaseClass.Screen
    {

        public RegisterScreen() : base("Register Page")
        {

        }

        public override void Show()
        {
            string name;
            string userName;
            string password;

            name = Console.ReadLine();
            userName = Console.ReadLine();
            password = Console.ReadLine();

            base.Show();
            Console.ReadKey();
        }

    }
}
