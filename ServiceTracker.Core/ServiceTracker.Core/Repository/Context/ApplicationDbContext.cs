using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServiceTracker.Core.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=default")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ApplicationDbContext>());

        }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Contract> Contract { get; set; }

        public DbSet<CustomerContract> CustomerContract { get; set; }

        public DbSet<Machine> Machine { get; set; }

        public DbSet<PurchaseOrder> PurchaseOrder { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<ExtendedIdentityUser>().ToTable("Users");
            //modelBuilder.Entity<AppRole>().ToTable("Roles");
            //modelBuilder.Entity<AppUserLogin>().ToTable("UserLogins");
            //modelBuilder.Entity<AppUserClaim>().ToTable("UserClaims");
            //modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles");

            //modelBuilder.Entity<Customer>().HasRequired(c => c.ContractType);

            
        }
    }
}