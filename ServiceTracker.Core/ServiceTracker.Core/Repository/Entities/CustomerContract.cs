using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceTracker.Core.Repository
{
    public class CustomerContract
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ContractId { get; set; }
    }
}