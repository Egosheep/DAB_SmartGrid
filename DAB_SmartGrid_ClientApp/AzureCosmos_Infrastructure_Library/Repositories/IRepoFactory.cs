namespace AzureCosmos_Infrastructure_Library.Repositories
{
    public interface IRepoFactory
    {
        ICompletedTransactionRepo CompletedTransactionRepo { get; }
        IPendingTransactionRepo PendingTransactionRepo { get; }
        IPowerInventoryRepo PowerInventoryRepo { get; }
    }
}