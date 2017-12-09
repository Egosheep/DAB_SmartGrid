using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using SQL_RestApi_Client.Models;

namespace SQL_RestApi_Client.Controllers
{
    public class SmartGridInfoesController : ApiController
    {
        private ProsumerContext db = new ProsumerContext();

        // GET: api/SmartGridInfoes
        public IQueryable<SmartGridInfo> GetSmartGridInfoes()
        {
            return db.SmartGridInfoes;
        }

        // GET: api/SmartGridInfoes/5
        [ResponseType(typeof(SmartGridInfo))]
        public async Task<IHttpActionResult> GetSmartGridInfo(int id)
        {
            SmartGridInfo smartGridInfo = await db.SmartGridInfoes.FindAsync(id);
            if (smartGridInfo == null)
            {
                return NotFound();
            }

            return Ok(smartGridInfo);
        }

        // PUT: api/SmartGridInfoes/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSmartGridInfo(int id, SmartGridInfo smartGridInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != smartGridInfo.Id)
            {
                return BadRequest();
            }

            db.Entry(smartGridInfo).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SmartGridInfoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/SmartGridInfoes
        [ResponseType(typeof(SmartGridInfo))]
        public async Task<IHttpActionResult> PostSmartGridInfo(SmartGridInfo smartGridInfo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SmartGridInfoes.Add(smartGridInfo);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = smartGridInfo.Id }, smartGridInfo);
        }

        // DELETE: api/SmartGridInfoes/5
        [ResponseType(typeof(SmartGridInfo))]
        public async Task<IHttpActionResult> DeleteSmartGridInfo(int id)
        {
            SmartGridInfo smartGridInfo = await db.SmartGridInfoes.FindAsync(id);
            if (smartGridInfo == null)
            {
                return NotFound();
            }

            db.SmartGridInfoes.Remove(smartGridInfo);
            await db.SaveChangesAsync();

            return Ok(smartGridInfo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SmartGridInfoExists(int id)
        {
            return db.SmartGridInfoes.Count(e => e.Id == id) > 0;
        }
    }
}