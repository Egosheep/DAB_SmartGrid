using System.Linq;
using SQL_Infrastructure_Library.Entities;

namespace SQL_Infrastructure_Library.CRUD
{
    public class CRUD<T> : ICRUD<T> where T : class, IHasIdentifier
    {
        private ProsumerContext _dbContext;
        public CRUD(ProsumerContext db)
        {
            _dbContext = db;
        }
        public void Create(T objectToCreate)
        {
            
        }

        public T ReadDocument(string idOfObject)
        {
            throw new System.NotImplementedException();
        }

        public void ReplaceDocument(T objectToReplace)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteDocument(string objectToDelete)
        {
            throw new System.NotImplementedException();
        }

        public IOrderedQueryable<T> Query()
        {
            throw new System.NotImplementedException();
        }
    }
}