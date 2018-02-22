using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServiceTracker.Core.Repository
{
    public class Entity
    {
        public int Id { get; set; }
        
        public byte[] RowVersion { get; set; }
    }
}