using GameConsoleBase.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameConsoleBase.BaseClass;

namespace GameConsoleBase.Pages
{
    internal class WelcomeScreen:BaseClass.Screen
    {
        public WelcomeScreen() : base("Welcome to my Game Console")
        {

        }

        public override void Show()
        {
            base.Show();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            base.CenterMiddle("Enjoy a variety of classic games!");
            Console.ResetColor();
            Console.ReadKey();
            Screen next = new MainMenuScreen();
            next.Show();


        }
    }
}
