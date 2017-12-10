namespace SmartGrid_ServerApp
{
    public interface ITransactionManager
    {
        void CreatePowerInventoryItem(Prosumer prosumer, string powerToSell);
        void CreateTransaction(Prosumer prosumer, string powerToBuy);
    }
}