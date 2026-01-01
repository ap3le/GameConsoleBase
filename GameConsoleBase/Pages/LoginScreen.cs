using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsoleBase.App;
using GameConsoleBase.BaseClass;
using GameConsoleBase.DB;
using GameConsoleBase.Models;

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
            bool success = false;
            while (!success)
            {
                Console.WriteLine("Enter username");
                String username = Console.ReadLine();
                Console.WriteLine("Enter password");
                String password = Console.ReadLine();

                User user = GameDB.UserLogin(username, password);
                if (user != null)
                {
                    Console.WriteLine("Login Successful!");
                    GameApp.LoginUser = user;
                 
                    success = true;
                }
                else
                {
                    Console.WriteLine("One of the password or username is incorrectly please try again <3");
                }


            }

            Console.ReadKey();
            GameMenu game = new GameMenu();
            game.Show();
        }


    }
}
