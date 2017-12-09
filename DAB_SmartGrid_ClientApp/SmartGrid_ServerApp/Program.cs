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
        static void Main(string[] args)
        {
            var loginManager = new LoginManager();
            var mainmenu = new MainMenu(loginManager);
            WebApiCaller.Client.BaseAddress = new Uri("http://localhost:64195/");
            WebApiCaller.Client.DefaultRequestHeaders.Accept.Clear();
            WebApiCaller.Client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
