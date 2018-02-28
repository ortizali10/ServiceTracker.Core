using ServiceTracker.Core.Repository;
using System.Collections.Generic;

namespace ServiceTracker.Core.Services
{
    public interface IQueryService
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomer(int id);
        Result AddCustomer(Customer customer);
        Result UpdateCustomer(int id);
        Result DeleteCustomer(int id);
    }
}