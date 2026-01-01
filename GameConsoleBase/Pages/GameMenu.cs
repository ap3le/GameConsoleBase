using GameConsoleBase.BaseClass;
using GameConsoleBase.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsoleBase.Pages
{
    internal class GameMenu : BaseClass.MenuScreen
    {
        public GameMenu() : base("Game Menu")
        {
            AddMenuItem("Fluffy", new GameScreen(new FluffyBirdGame()));
            AddMenuItem("PacMan", new GameScreen(new PacManGame()));
            AddMenuItem("TetrisGame", new GameScreen(new TetrisGame()));

        }
    }
}
