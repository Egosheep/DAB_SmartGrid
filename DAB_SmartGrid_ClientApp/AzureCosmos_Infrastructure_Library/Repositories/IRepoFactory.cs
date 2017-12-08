namespace AzureCosmos_Infrastructure_Library.Repositories
{
    public interface IRepoFactory
    {
        ICompletedTransactionsRepo CompletedTransactionsRepo { get; }
        IPendingTransactionsRepo PendingTransactionsRepo { get; }
        IPowerInventoryRepo PowerInventoryRepo { get; }
    }
}