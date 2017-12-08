using AzureCosmos_Infrastructure_Library.Collections;
using AzureCosmos_Infrastructure_Library.CRUD;

namespace AzureCosmos_Infrastructure_Library.Repositories
{
    public class CompletedTransactionsRepo : GenericRepo<CompletedTransactions>, ICompletedTransactionsRepo
    {
        public CompletedTransactionsRepo(ICRUD<CompletedTransactions> crud) : base(crud)
        {
        }
    }
}