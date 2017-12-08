
using AzureCosmos_Infrastructure_Library.Collections;
using AzureCosmos_Infrastructure_Library.CRUD;

namespace AzureCosmos_Infrastructure_Library.Repositories
{
    public class RepoFactory : IRepoFactory
    {
        private ICompletedTransactionRepo _completedTransactionRepo;
        private IPendingTransactionRepo _pendingTransactionRepo;
        private IPowerInventoryRepo _powerInventoryRepo;

        ICompletedTransactionRepo IRepoFactory.CompletedTransactionRepo => _completedTransactionRepo ??
                                                                             (_completedTransactionRepo =
                                                                                 new CompletedTransactionRepo(
                                                                                     new CRUD<CompletedTransaction>(
                                                                                         CosmosConnection.databaseName,
                                                                                         CosmosConnection
                                                                                             .completedTransactionsCollection)));

        IPendingTransactionRepo IRepoFactory.PendingTransactionRepo => _pendingTransactionRepo ??
                                                                             (_pendingTransactionRepo =
                                                                                 new PendingTransactionRepo(
                                                                                     new CRUD<PendingTransaction>(
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