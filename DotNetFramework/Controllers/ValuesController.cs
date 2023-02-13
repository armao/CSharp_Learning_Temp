using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        NorthwindEntities1 db = new NorthwindEntities1();

        // GET api/values
        public IEnumerable<Customers> Get()
        {
            return db.Customers;
        }
        //public IEnumerable<string> Get()
        //{

        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        //public Customers Get(string id)
        //{
        //    Customers value = db.Customers.Find(id);

        //    return value;
        //}

        public Customers Get(string id,string pw)
        {
            Customers value = db.Customers.Where();

            return value;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
