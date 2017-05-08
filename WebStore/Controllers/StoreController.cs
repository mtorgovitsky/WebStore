using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebStore.Models;

namespace WebStore
{
    public class StoreController : ApiController
    {
        List<Product> products;

        // GET api/<controller>
        public IEnumerable<Product> Get()
        {
            products  = new List<Product> 
                {
                    new Product { Name = "Product1", Price = 33.6M },
                    new Product { Name = "Product2", Price = 32.56M },
                    new Product { Name = "Product3", Price = 23.51M },
                    new Product { Name = "Product4", Price = 47.58M }
                };

            return products;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}