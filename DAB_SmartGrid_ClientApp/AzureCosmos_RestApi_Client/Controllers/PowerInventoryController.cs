using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AzureCosmos_Infrastructure_Library.Collections;

namespace AzureCosmos_RestApi_Client.Controllers
{
    public class PowerInventoryController : ApiController
    {
        // GET: api/PowerInventory
        public IEnumerable<PowerInventory> Get()
        {
            return WebApiApplication.PowerInventoryRepo.GetAllInventoryItems();
        }

        // GET: api/PowerInventory/5
        public PowerInventory Get(string id)
        {
            return WebApiApplication.PowerInventoryRepo.Get(id);
        }

        // POST: api/PowerInventory
        public string Post(PowerInventory inventoryItem)
        {
            return WebApiApplication.PowerInventoryRepo.Create(inventoryItem);
        }

        // PUT: api/PowerInventory/5
        public void Put(PowerInventory inventoryItem)
        {
            WebApiApplication.PowerInventoryRepo.Update(inventoryItem);
        }

        // DELETE: api/PowerInventory/5
        public void Delete(string id)
        {
            WebApiApplication.PowerInventoryRepo.Delete(id);
        }
    }
}
