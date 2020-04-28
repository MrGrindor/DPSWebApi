using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DPSWebApi.Models;

namespace DPSWebApi.Controllers
{
    public class TileController : ApiController
    {
        private Tile[] tileMap = new Tile[]
        {
           new Tile{id=0,name="Tile1",owner=null,type="ocean",x=1,y=1,gold=0,culture=0,food=0,production=0,faith=0,science=0,improvement=null}
        }; 
        
        // GET: api/Tile
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Tile/5
        public Tile Get(int id)
        {
            return tileMap[id];
        }

        // POST: api/Tile
        public void Post([FromBody]string value)
        {

        }

        // PUT: api/Tile/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Tile/5
        public void Delete(int id)
        {
        }
    }
}
