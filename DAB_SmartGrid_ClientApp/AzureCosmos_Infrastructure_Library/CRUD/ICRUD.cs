using System;
using System.Linq;
using System.Threading.Tasks;

namespace AzureCosmos_Infrastructure_Library.CRUD
{
    public interface ICRUD<T>
    {
        Task CreateDocument(T objectToCreate);
        Task<T> ReadDocument(string idOfObject);
        Task<bool> ReplaceDocument(T objectToReplace);
        Task<bool> DeleteDocument(Guid objectToDelete);
        IOrderedQueryable<T> Query();
    }
}