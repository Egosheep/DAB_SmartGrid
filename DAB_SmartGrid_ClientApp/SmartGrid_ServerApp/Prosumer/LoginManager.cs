using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace SmartGrid_ServerApp
{
    public class LoginManager : ILoginManager
    {
        public async Task<Prosumer> ValidateLogin(int id)
        {
            var getPath = SqlWebApiCaller.Client.BaseAddress + "Prosumers/" + id;
            HttpResponseMessage response = await SqlWebApiCaller.Client.GetAsync(getPath);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsAsync<Prosumer>();
            }
            return null;
        }
    }
}