using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents.SystemFunctions;
using AzureCosmos_Infrastructure_Library.Collections;

namespace AzureCosmos_Infrastructure_Library.CRUD
{
    public class CRUD<T> : ICRUD<T> where T : class, IHasIdentifier
    {
        private readonly string _databaseId;
        private readonly string _collectionId;
        private readonly Uri _collectionUri;

        public CRUD(string databaseId, string collectionId)
        {
            _databaseId = databaseId;
            _collectionId = collectionId;
            _collectionUri = UriFactory.CreateDocumentCollectionUri(_databaseId, _collectionId);
        }

        public async Task<string> CreateDocument(T objectToCreate)
        {
            var documentRespons = await CosmosConnection.Client.CreateDocumentAsync(_collectionUri, objectToCreate).ConfigureAwait(false);
            objectToCreate.Id = documentRespons.Resource.Id;
            return documentRespons.Resource.Id;
        }

        public async Task<bool> DeleteDocument(Guid objectToDelete)
        {
            try
            {
                await CosmosConnection.Client.DeleteDocumentAsync(UriFactory.CreateDocumentUri(_databaseId,
                    _collectionId, objectToDelete.ToString())).ConfigureAwait(false);
                return true;
            }
            catch (DocumentClientException de)
            {
                if (de.StatusCode == HttpStatusCode.NotFound)
                {
                    Debug.WriteLine(de);
                    Debug.WriteLine("Not found.");
                }
                else
                {
                    Debug.WriteLine(de);
                }
                return false;
            }
        }

        public IOrderedQueryable<T> Query()
        {
            FeedOptions queryOptions = new FeedOptions() { MaxItemCount = -1 };
            return CosmosConnection.Client.CreateDocumentQuery<T>(_collectionUri, queryOptions);
        }

        public async Task<T> ReadDocument(string idOfObject)
        {
            try
            {
                var documentResponse = await CosmosConnection.Client.ReadDocumentAsync<T>(UriFactory.CreateDocumentUri(
                    _databaseId, _collectionId, idOfObject)).ConfigureAwait(false);
                return documentResponse.Document;
            }
            catch (DocumentClientException de)
            {
                if (de.StatusCode == HttpStatusCode.NotFound)
                {
                    Debug.WriteLine("Not found.");
                }
                return null;
            }
        }

        public async Task<bool> ReplaceDocument(T objectToReplace)
        {
            try
            {
                await CosmosConnection.Client.ReplaceDocumentAsync(
                    UriFactory.CreateDocumentUri(_databaseId, _collectionId, objectToReplace.Id), objectToReplace).ConfigureAwait(false);
                return true;
            }
            catch (DocumentClientException de)
            {
                if (de.StatusCode == HttpStatusCode.NotFound)
                {
                    Debug.WriteLine(de);
                    Debug.WriteLine("Not found.");
                }
                else
                {
                    Debug.WriteLine(de);
                }
                return false;
            }
        }
    }
}