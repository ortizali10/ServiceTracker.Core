using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using ServiceTracker.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ServiceTracker.Core
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            ApplicationDbContext db = new ApplicationDbContext();
            RoleStore<IdentityRole> rolestore = new RoleStore<IdentityRole>(db);
            RoleManager<IdentityRole> rolemanage = new RoleManager<IdentityRole>(rolestore);
            UserStore<ExtendedIdentityUser> userStore = new UserStore<ExtendedIdentityUser>(db);
            UserManager<ExtendedIdentityUser> userManager = new UserManager<ExtendedIdentityUser>(userStore);

            string adminRole = nameof(Role.ADMINISTRATOR);
            string seRole = nameof(Role.SERVICEENGINEER);
            string wcRole = nameof(Role.WORKCONTROLLER);

            if (!rolemanage.RoleExists(adminRole))
            {
                rolemanage.Create(new IdentityRole() { Name = adminRole });
            }

            if (!rolemanage.RoleExists(wcRole))
            {
                rolemanage.Create(new IdentityRole() { Name = seRole });
            }

            if (!rolemanage.RoleExists(seRole))
            {
                rolemanage.Create(new IdentityRole() { Name = wcRole });
            }

            if (userManager.FindByName("Administrator") == null)
            {
                var user = new ExtendedIdentityUser
                {
                    UserName = "administrator",
                    Email = "admin@admin.com",
                    FirstName = "admin",
                    LastName = "admin"
                };
                userManager.Create(user, "it$$001");

                userManager.AddToRole(user.Id, "Administrator");
            }
        }
        
    }
}
