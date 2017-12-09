namespace SmartGrid_ServerApp
{
    public interface ILoginManager
    {
        Prosumer ValidateLogin(int id);
    }
}