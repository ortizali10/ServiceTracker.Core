using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceTracker.Core.Repository
{
    public class Customer
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public string  Address { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string ContactPerson { get; set; }

        public string ContractType { get; set; } // To be changed to contract object
    }
}