using AzureCosmos_Infrastructure_Library.Collections;
using AzureCosmos_Infrastructure_Library.CRUD;

namespace AzureCosmos_Infrastructure_Library.Repositories
{
    public class PendingTransactionsRepo : GenericRepo<PendingTransactions>, IPendingTransactionsRepo
    {
        public PendingTransactionsRepo(ICRUD<PendingTransactions> crud) : base(crud)
        {
        }
    }
}