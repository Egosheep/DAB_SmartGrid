using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AzureCosmos_Infrastructure_Library.Collections;

namespace AzureCosmos_RestApi_Client.Controllers
{
    public class CompletedTransactionsController : ApiController
    {
        // GET: api/CompletedTransaction
        public IEnumerable<CompletedTransaction> Get()
        {
            return WebApiApplication.CompletedTransactionRepo.GetAllCompletedTransactions();
        }

        // GET: api/CompletedTransaction/5
        public CompletedTransaction Get(string id)
        {
            return WebApiApplication.CompletedTransactionRepo.Get(id);
        }

        // POST: api/CompletedTransaction
        public string Post(CompletedTransaction completedTransaction)
        {
            return WebApiApplication.CompletedTransactionRepo.Create(completedTransaction);
        }

        // DELETE: api/CompletedTransaction/5
        public void Delete(string id)
        {
            WebApiApplication.CompletedTransactionRepo.Delete(id);
        }

        // QUERY: api/CompletedTransactions/5
        [HttpGet]
        public IEnumerable<CompletedTransaction> Query(string queryOption)
        {
            return WebApiApplication.CompletedTransactionRepo.WhereQuery(queryOption);
        }
    }
}
