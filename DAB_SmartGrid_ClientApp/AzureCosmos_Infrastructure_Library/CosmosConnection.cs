using System;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;

namespace AzureCosmos_Infrastructure_Library
{
    public class CosmosConnection
    {
        private const string EndpointUrl = "https://localhost:8081";
        private const string PrimaryKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";

        public static DocumentClient Client;

        public const string databaseName = "SmartGridDB";
        public const string completedTransactionsCollection = "CompletedTransaction";
        public const string powerInventoryCollection = "PowerInventory";
        public const string pendingTransactionCollection = "PendingTransaction";

        #region Thread safe singleton Imeplementation

        static CosmosConnection()
        {
            StartUp().Wait();
        }

        private CosmosConnection()
        {
            
        }

        public static CosmosConnection Instance { get; } = new CosmosConnection();

        #endregion

        public static async Task StartUp()
        {
            var databaseUri = UriFactory.CreateDatabaseUri(databaseName);
            Client = new DocumentClient(new Uri(EndpointUrl), PrimaryKey);
            Client.CreateDatabaseIfNotExistsAsync(new Database() { Id = databaseName }).Wait();
            Client.CreateDocumentCollectionIfNotExistsAsync(databaseUri,
                new DocumentCollection { Id = completedTransactionsCollection }).Wait();
            Client.CreateDocumentCollectionIfNotExistsAsync(databaseUri,
                new DocumentCollection { Id = powerInventoryCollection }).Wait();
            Client.CreateDocumentCollectionIfNotExistsAsync(databaseUri,
                new DocumentCollection { Id = pendingTransactionCollection }).Wait();
        }
    }
}