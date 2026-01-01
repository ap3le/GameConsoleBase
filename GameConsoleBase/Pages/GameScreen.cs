using GameConsoleBase.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
    internal class GameScreen : BaseClass.Screen
    {
        IGamePlay game;

        public GameScreen(IGamePlay game):base(game.Name)
        {
            this.game = game;
        }

        public override void Show()
        {
            base.Show();
            Console.BackgroundColor = ConsoleColor.Cyan;
            CenterMiddle("Press any key to start playing");
            Console.ResetColor();
            Console.ReadKey();
            game.Play();
        }

    }
}
