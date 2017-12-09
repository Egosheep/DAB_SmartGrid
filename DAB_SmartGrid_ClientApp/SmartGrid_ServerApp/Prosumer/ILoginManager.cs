using System.Threading.Tasks;

namespace SmartGrid_ServerApp
{
    public interface ILoginManager
    {
        Task<Prosumer> ValidateLogin(int id);
    }
}