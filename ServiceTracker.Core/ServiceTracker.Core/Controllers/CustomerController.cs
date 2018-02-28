using ServiceTracker.Core.Repository;
using ServiceTracker.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace ServiceTracker.Core.Controllers
{
    [RoutePrefix("api")]
    public class CustomerController : ApiController
    {
        private readonly IQueryService _queryService;

        public CustomerController(IQueryService queryService)
        {
            _queryService = queryService;
        }

        [HttpGet]
        [Route("customers")]
        public IHttpActionResult GetAllCustomers()
        {
            var response = _queryService.GetAllCustomers();

            return Json(response);
        }

        [HttpGet]
        [Route("customers/{id}")]
        public IHttpActionResult GetCustomerById(int id)
        {
            var response = _queryService.GetCustomer(id);
            return Json(response);
        }

        [HttpPost]
        [Route("customers")]
        public IHttpActionResult AddCustomer(Customer customer)
        {
            var response = _queryService.AddCustomer(customer);
            return Json(response);
        }

        [HttpDelete]
        [Route("customers")]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var response = _queryService.DeleteCustomer(id);
            return Json(response);
        }

        [HttpPut]
        [Route("customers")]
        public IHttpActionResult UpdateCustomer(int id)
        {
            var response = _queryService.UpdateCustomer(id);
            return Json(response);
        }

        // Get customer by id

        // Create new customer

        // Update customer

        // Delete customer
    }
}
