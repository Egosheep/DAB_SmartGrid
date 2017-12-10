using System.Net.Http;

namespace SmartGrid_ServerApp
{
    public class SqlWebApiCaller
    {
        static SqlWebApiCaller()
        {

        }

        private SqlWebApiCaller()
        {

        }

        public static SqlWebApiCaller Instance { get; } = new SqlWebApiCaller();

        public static HttpClient Client = new HttpClient();
    }
}