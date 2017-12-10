using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AzureCosmos_Infrastructure_Library.Collections;

namespace AzureCosmos_RestApi_Client.Controllers
{
    public class PendingTransactionsController : ApiController
    {
        // GET: api/PendingTransaction
        public IEnumerable<PendingTransaction> Get()
        {
            return WebApiApplication.PendingTransactionRepo.GetAllPendingTransactions();
        }

        // GET: api/PendingTransaction/5
        public PendingTransaction Get(string id)
        {
            return WebApiApplication.PendingTransactionRepo.Get(id);
        }

        // POST: api/PendingTransaction
        public string Post(PendingTransaction pendingTransaction)
        {
            return WebApiApplication.PendingTransactionRepo.Create(pendingTransaction);
        }

        // DELETE: api/PendingTransaction/5
        public void Delete(string id)
        {
            WebApiApplication.PendingTransactionRepo.Delete(id);
        }

        // QUERY: api/PendingTransaction/5
        [HttpGet]
        public IEnumerable<PendingTransaction> Query(string options)
        {
            return WebApiApplication.PendingTransactionRepo.WhereQuery(options);
        }
    }
}
