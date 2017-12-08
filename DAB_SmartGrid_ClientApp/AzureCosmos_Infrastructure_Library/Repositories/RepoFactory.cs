
using AzureCosmos_Infrastructure_Library.Collections;
using AzureCosmos_Infrastructure_Library.CRUD;

namespace AzureCosmos_Infrastructure_Library.Repositories
{
    public class RepoFactory : IRepoFactory
    {
        private ICompletedTransactionsRepo _completedTransactionsRepo;
        private IPendingTransactionsRepo _pendingTransactionsRepo;
        private IPowerInventoryRepo _powerInventoryRepo;

        ICompletedTransactionsRepo IRepoFactory.CompletedTransactionsRepo => _completedTransactionsRepo ??
                                                                             (_completedTransactionsRepo =
                                                                                 new CompletedTransactionsRepo(
                                                                                     new CRUD<CompletedTransactions>(
                                                                                         CosmosConnection.databaseName,
                                                                                         CosmosConnection
                                                                                             .completedTransactionsCollection)));

        IPendingTransactionsRepo IRepoFactory.PendingTransactionsRepo => _pendingTransactionsRepo ??
                                                                             (_pendingTransactionsRepo =
                                                                                 new PendingTransactionsRepo(
                                                                                     new CRUD<PendingTransactions>(
                                                                                         CosmosConnection.databaseName,
                                                                                         CosmosConnection
                                                                                             .pendingTransactionCollection)));

        IPowerInventoryRepo IRepoFactory.PowerInventoryRepo => _powerInventoryRepo ?? (_powerInventoryRepo =
                                                                   new PowerInventoryRepo(
                                                                       new CRUD<PowerInventory>(
                                                                           CosmosConnection.databaseName,
                                                                           CosmosConnection.powerInventoryCollection)));
    }
}