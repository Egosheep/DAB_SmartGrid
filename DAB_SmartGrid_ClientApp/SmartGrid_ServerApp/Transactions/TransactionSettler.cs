using System.Collections.Generic;
using System.Net.Http;

namespace SmartGrid_ServerApp
{
    public class TransactionSettler : ITransactionSettler
    {
        private IPriceRegulator _priceRegulator;

        public TransactionSettler()
        {
            _priceRegulator = Program.PriceRegulator;
        }

        public void CompleteDailyTransactions()
        {
            var pendingTransactionList = GetPendingTransactions();
            foreach (PendingTransaction pendingTransaction in pendingTransactionList)
            {
                var completeTransaction = new CompletedTransaction()
                {
                    BuyerId = pendingTransaction.BuyerId,
                    SellerId = pendingTransaction.SellerId,
                    PowerAmount = pendingTransaction.PowerAmount,
                    TransactionTime = pendingTransaction.TransactionTime,
                    TransactionPrice = _priceRegulator.CalculateToken(pendingTransaction).ToString()
                };
                SaveCompletedTransactions(completeTransaction);
            }
        }

        private List<PendingTransaction> GetPendingTransactions()
        {
            var getPath = AzureWebApiCaller.Client.BaseAddress + "PendingTransactions/";
            var httpRecieve = AzureWebApiCaller.Client.GetAsync(getPath);
            return httpRecieve.Result.Content.ReadAsAsync<List<PendingTransaction>>().Result;
        }

        private void SaveCompletedTransactions(CompletedTransaction transactionToSave)
        {
            var postPath = AzureWebApiCaller.Client.BaseAddress + "CompletedTransactions/";
            AzureWebApiCaller.Client.PostAsJsonAsync(postPath, transactionToSave);
        }
    }
}