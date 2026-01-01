using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using GameConsoleBase.BaseClass;
using GameConsoleBase.DB;
using GameConsoleBase.Models;

namespace GameConsoleBase.Pages
{
    internal class RegisterScreen:BaseClass.Screen
    {

        public RegisterScreen() : base("Register Page")
        {
            
        }

        public override void Show()
        {

            base.Show();

            string name;
            string userName;
            string password;

            

            bool success = false;

            while (!success) {
                Console.WriteLine("Enter Name: ");
                name = Console.ReadLine();

                Console.WriteLine("Enter Username: ");
                userName = Console.ReadLine();

                Console.WriteLine("Enter Password: ");
                password = Console.ReadLine();

                while (!IsValidPassword(password))
                {
                    Console.WriteLine("Enter Valid Password: ");
                    password = Console.ReadLine();
                }

                while (!isValidUserName(userName))
                {
                    Console.WriteLine("Enter Valid Username: ");
                    password = Console.ReadLine();
                }

             
                success = GameDB.RegisterUser(new User(name, userName, password));
                if (success)
                {
                    Console.WriteLine("Registration Succesfully!");
                }
                else
                {
                    Console.WriteLine("Failed to Register :(");
                }


            }


            Console.ReadKey();
            Console.Clear();
        }

        private bool isValidUserName(string? userName)
        {
            if(string.IsNullOrEmpty(userName) || userName.Length < 4)
            {
                Console.WriteLine("Username must be at least 4 characters long and cannot be empty.");
                return false;
            }
            return true;
        }
        private bool IsValidPassword(string password)
        {
            if(password == null || password.Length < 6 || !password.Contains("@") || string.IsNullOrEmpty(password))
            {
                Console.WriteLine("Password must be at least 6 characters long and contains '@' ");
                return false;
            }
            return true;
        }

    }


}
