using System;

namespace AzureCosmos_Infrastructure_Library.Repositories
{
    public interface IGenericRepo<T>
    {
        T Get(string id);
        string Create(T objectToCreate);
        bool Update(T objectToUpdate);
        bool Delete(string objectToDeleteId);
    }
}