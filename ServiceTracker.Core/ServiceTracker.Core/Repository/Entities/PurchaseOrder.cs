using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceTracker.Core.Repository
{
    public class PurchaseOrder
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int MachineId { get; set; }

        public DateTime InstallationDate { get; set; }

        public int InvoiceNumber { get; set; }
    }
}