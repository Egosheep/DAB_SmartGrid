using System.Linq;
using SQL_Infrastructure_Library.Entities;

namespace SQL_Infrastructure_Library.CRUD
{
    public class CRUD<T>
    {
        private ProsumerContext _dbContext;
        public CRUD(ProsumerContext db)
        {
            _dbContext = db;
        }
        public void Create(T objectToCreate)
        {
            
        }

        public T Read(int idOfObject)
        {
            throw new System.NotImplementedException();
        }

        public void Update(T objectToReplace)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(string objectToDelete)
        {
            throw new System.NotImplementedException();
        }

        public IOrderedQueryable<T> Query()
        {
            throw new System.NotImplementedException();
        }
    }
}