using System.Linq;

namespace SQL_Infrastructure_Library.CRUD
{
    public interface ICRUD<T>
    {
        void Create(T objectToCreate);
        T Read(string idOfObject);
        void Update(T objectToReplace);
        void Delete(string objectToDelete);
        IOrderedQueryable<T> Query();
    }
}