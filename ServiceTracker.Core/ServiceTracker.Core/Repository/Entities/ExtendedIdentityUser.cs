using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace ServiceTracker.Core.Repository
{
    public class ExtendedIdentityUser : IdentityUser
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
    }
}