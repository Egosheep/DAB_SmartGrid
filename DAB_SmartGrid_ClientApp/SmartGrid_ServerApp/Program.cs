using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGrid_ServerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var lmanager = new LoginManager();
            var mainmenu = new MainMenu(lmanager);
        }
    }
}
