namespace SmartGrid_ServerApp
{
    public interface ILoginManager
    {
        IProsumer ValidateLogin(int id);
    }
}