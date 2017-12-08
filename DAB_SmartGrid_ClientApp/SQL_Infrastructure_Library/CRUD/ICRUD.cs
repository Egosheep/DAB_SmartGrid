using System.Linq;

namespace SQL_Infrastructure_Library.CRUD
{
    public interface ICRUD<T>
    {
        void Create(T objectToCreate);
        T ReadDocument(string idOfObject);
        void ReplaceDocument(T objectToReplace);
        void DeleteDocument(string objectToDelete);
        IOrderedQueryable<T> Query();
    }
}