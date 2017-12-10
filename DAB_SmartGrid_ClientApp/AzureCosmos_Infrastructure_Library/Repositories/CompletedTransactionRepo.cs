using System.Collections.Generic;
using System.Linq;
using AzureCosmos_Infrastructure_Library.Collections;
using AzureCosmos_Infrastructure_Library.CRUD;

namespace AzureCosmos_Infrastructure_Library.Repositories
{
    public class CompletedTransactionRepo : GenericRepo<CompletedTransaction>, ICompletedTransactionRepo
    {
        public CompletedTransactionRepo(ICRUD<CompletedTransaction> crud) : base(crud)
        {
        }

        public List<CompletedTransaction> GetAllCompletedTransactions()
        {
            return _crud.Query().ToList();
        }

        public List<CompletedTransaction> WhereQuery(string options)
        {
            return _crud.Query().Where(f => f.SellerId == options || f.BuyerId == options).ToList();
        }
    }
}