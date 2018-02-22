using ServiceTracker.Core.Repository;
using ServiceTracker.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ServiceTracker.Core.Controllers
{
    public class ResourceController : ApiController
    {
        // GET api/<controller>
        private readonly IQueryService _queryService;
        public ResourceController(IQueryService queryService)
        {
            _queryService = queryService;
        }
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpGet]
        public IEnumerable<Customer> test()
        {
            var test = _queryService.GetAllCustomers();
            return test;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
        [HttpGet]
        public void testing()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var cust = new Customer()
                {
                    Address = ""

                };

                ctx.Customer.Add(cust);
                ctx.SaveChanges();
            }
        }
        
    }
}
