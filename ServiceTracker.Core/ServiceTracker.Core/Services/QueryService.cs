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
        #region Customer

        public Result AddCustomer(Customer customer)
        {
            var result = new Result();
            try
            {
                _repo.Add(customer);
                _repo.Save();
                result.ErrorCode = ErrorCode.DEFAULT;
                result.Success = true;
                result.Message = "Succesfully added customer.";
            }
            catch (Exception e)
            {
                result.ErrorCode = ErrorCode.EXCEPTION;
                result.Success = false;
                result.Message = String.Format("Error adding customer: ", e.Message);
            }
            return result;
        }

        public Result DeleteCustomer(int id)
        {
            var result = new Result();
            try
            {
                var customer = _repo.Get<Customer>(id);
                if (customer != null)
                {
                    _repo.Remove(customer);
                    _repo.Save();
                    result.ErrorCode = ErrorCode.DEFAULT;
                    result.Success = true;
                    result.Message = "Succesfully removed customer.";
                    return result;
                }
                result.ErrorCode = ErrorCode.DATA_NOT_FOUND;
                result.Success = false;
                result.Message = "Cannot find customer.";
                return result;

            }
            catch (Exception e)
            {
                result.ErrorCode = ErrorCode.EXCEPTION;
                result.Success = false;
                result.Message = String.Format("Error adding customer: ", e.Message);
            }
            return result;
        }

        public List<Customer> GetAllCustomers()
        {
            return _repo.Getall<Customer>().ToList();
        }

        public Customer GetCustomer(int id)
        {
            return _repo.Get<Customer>(id);
        }

        public Result UpdateCustomer(int id)
        {
            var result = new Result();
            try
            {
                var customer = _repo.Get<Customer>(id);
                if (customer != null)
                {
                    _repo.Update(customer);
                    _repo.Save();
                    result.ErrorCode = ErrorCode.DEFAULT;
                    result.Success = true;
                    result.Message = "Succesfully removed customer.";
                    return result;
                }
                result.ErrorCode = ErrorCode.DATA_NOT_FOUND;
                result.Success = false;
                result.Message = "Cannot find customer.";
                return result;
            }
            catch (Exception e)
            {
                result.ErrorCode = ErrorCode.EXCEPTION;
                result.Success = false;
                result.Message = String.Format("Error adding customer: ", e.Message);
            }
            return result;
        }

        #endregion

    }
}