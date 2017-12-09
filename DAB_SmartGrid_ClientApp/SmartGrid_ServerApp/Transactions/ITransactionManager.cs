namespace SmartGrid_ServerApp
{
    public interface ITransactionManager
    {
        void CreatePowerInventoryItem(Prosumer prosumer);
        PendingTransaction CreateTransaction(Prosumer prosumer, PowerInventory inventory);
    }
}