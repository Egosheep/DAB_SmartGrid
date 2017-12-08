using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SQL_RestApi_Client.Models
{
    public class ProsumerContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ProsumerContext() : base("name=ProsumerContext")
        {
        }

        public System.Data.Entity.DbSet<SQL_RestApi_Client.Models.Address> Addresses { get; set; }

        public System.Data.Entity.DbSet<SQL_RestApi_Client.Models.Prosumer> Prosumers { get; set; }
    }
}
