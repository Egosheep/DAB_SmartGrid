using System.Net.Http;

namespace SmartGrid_ServerApp
{
    public class AzureWebApiCaller
    {
        static AzureWebApiCaller()
        {

        }

        private AzureWebApiCaller()
        {

        }

        public static AzureWebApiCaller Instance { get; } = new AzureWebApiCaller();

        public static HttpClient Client = new HttpClient();
    }
}