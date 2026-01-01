using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsoleBase.BaseClass;

namespace GameConsoleBase.Pages
{
    internal class LoginScreen:BaseClass.Screen
    {

        public LoginScreen() : base("Login Page")
        {

        }

        public override void Show()
        {
            base.Show();
            Console.ReadKey();
            GameMenu game = new GameMenu();
            game.Show();
        }


    }
}
