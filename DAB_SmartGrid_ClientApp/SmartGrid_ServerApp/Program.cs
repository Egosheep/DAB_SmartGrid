using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SmartGrid_ServerApp
{
    class Program
    {
        public static IPriceRegulator PriceRegulator;
        static void Main(string[] args)
        {
            AzureWebApiCaller.Client.BaseAddress = new Uri("http://localhost:58644/api/");
            AzureWebApiCaller.Client.DefaultRequestHeaders.Accept.Clear();
            AzureWebApiCaller.Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            SqlWebApiCaller.Client.BaseAddress = new Uri("http://localhost:58622/api/");
            SqlWebApiCaller.Client.DefaultRequestHeaders.Accept.Clear();
            SqlWebApiCaller.Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var loginManager = new LoginManager();
            PriceRegulator = new PriceRegulator();
            var mainmenu = new MainMenu(loginManager);
            mainmenu.DisplayMenu();
        }
    }
}
