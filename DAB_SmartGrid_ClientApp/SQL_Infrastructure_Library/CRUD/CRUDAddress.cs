using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Infrastructure_Library.CRUD
{
    using System.Data.Entity.Migrations;

    using SQL_Infrastructure_Library.Entities;
    class CRUDAddress
    {
        private ProsumerContext DbContext;

        public CRUDAddress(ProsumerContext db)
        {
            DbContext = db;
        }
        public void Create(Address objectToCreate)
        {
            this.DbContext.Addresses.AddOrUpdate(objectToCreate);
            this.DbContext.SaveChanges();
        }

        public Address Read(int idOfObject)
        {
            return this.DbContext.Addresses.FirstOrDefault(j => j.Id == idOfObject);
        }

        public void Update(Address objectToReplace)
        {
            
        }

        public void Delete(string objectToDelete)
        {
            throw new NotImplementedException();
        }

        public IOrderedQueryable<Address> Query()
        {
            throw new NotImplementedException();
        }
    }
}
