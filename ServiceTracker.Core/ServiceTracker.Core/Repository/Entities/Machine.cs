using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceTracker.Core.Repository
{
    public class Machine
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
        public Type Type { get; set; }
    }
}