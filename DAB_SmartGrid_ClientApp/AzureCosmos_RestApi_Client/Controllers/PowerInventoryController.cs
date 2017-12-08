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
            return WebApiApplication.PowerInventoryRepo.
        }

        // GET: api/PowerInventory/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PowerInventory
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/PowerInventory/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/PowerInventory/5
        public void Delete(int id)
        {
        }
    }
}
