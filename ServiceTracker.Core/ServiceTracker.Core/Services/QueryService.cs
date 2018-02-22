using ServiceTracker.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceTracker.Core.Repository;

namespace ServiceTracker.Core
{
    public class QueryService : IQueryService
    {
        protected readonly IRepository _repo;

        public QueryService(IRepository repo)
        {
            _repo = repo;
        }

        public void AddCustomer(Customer customer)
        {
            _repo.Add(customer);
        }

        public List<Customer> GetAllCustomers()
        {
            return _repo.Getall<Customer>().ToList();
        }

        public Customer GetCustomer(int id)
        {
            return _repo.Get<Customer>(id);
        }
    }
}