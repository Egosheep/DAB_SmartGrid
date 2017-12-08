using System;
using AzureCosmos_Infrastructure_Library.CRUD;

namespace AzureCosmos_Infrastructure_Library.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T>
    {
        protected readonly ICRUD<T> _crud;
        public GenericRepo(ICRUD<T> crud)
        {
            _crud = crud;
        }

        public T Get(string id)
        {
            var task = _crud.ReadDocument(id);
            task.Wait();
            return task.Result;
        }

        public string Create(T objectToCreate)
        {
            var task = _crud.CreateDocument(objectToCreate);
            task.Wait();
            return task.Result;
        }

        public bool Update(T objectToUpdate)
        {
            var task = _crud.ReplaceDocument(objectToUpdate);
            task.Wait();
            return task.Result;
        }

        public bool Delete(Guid objectToDeleteId)
        {
            var task = _crud.DeleteDocument(objectToDeleteId);
            task.Wait();
            return task.Result;
        }
    }
}