using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Towel;

namespace GameConsoleBase.Pages
{
    internal class MainMenuScreen : BaseClass.MenuScreen
    {
        public MainMenuScreen() : base("Main Menu")
        {
            AddMenuItem("Login", new LoginScreen());
            AddMenuItem("Register", new RegisterScreen());
        }

        public override void Show()
        {
           base.Show();
        }
    }
}
