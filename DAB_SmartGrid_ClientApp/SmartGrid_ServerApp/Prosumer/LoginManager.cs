using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace SmartGrid_ServerApp
{
    public class LoginManager : ILoginManager
    {
        private const string _path = "";

        public async Task<Prosumer> ValidateLogin(int id)
        {
            HttpResponseMessage response = await WebApiCaller.Client.GetAsync(_path);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<Prosumer>();
            }
            return null;
        }
    }
}