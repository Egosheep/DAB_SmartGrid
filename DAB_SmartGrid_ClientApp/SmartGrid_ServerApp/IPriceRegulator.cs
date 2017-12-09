namespace SmartGrid_ServerApp
{
    public interface IPriceRegulator
    {
        double CalculateToken(IPendingTransaction transaction);
    }
}