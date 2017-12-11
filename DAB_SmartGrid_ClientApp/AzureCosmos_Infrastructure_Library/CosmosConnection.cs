using System;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;

namespace AzureCosmos_Infrastructure_Library
{
    public class CosmosConnection
    {
        private const string EndpointUrl = "https://e17i4dab.documents.azure.com:443/";
        private const string PrimaryKey = "yKZkWkft7yTABm1e8ZaVuDpDLv5t3LkJvbXjwQHzzoWZz0UkvrYaXkWkVkfKoRQe0Vvv9GfuBpXNtfzMBtqcPA==";

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