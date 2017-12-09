namespace SmartGrid_ServerApp
{
    public interface IPriceRegulator
    {
        double CalculateToken(PendingTransaction transaction);
    }
}