using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServiceTracker.Core.Repository
{
    public class ApplicationDbContext : IdentityDbContext<ExtendedIdentityUser>
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
            modelBuilder.Entity<ExtendedIdentityUser>().ToTable("Users").HasKey(c => c.Id);
            modelBuilder.Entity<IdentityRole>().ToTable("Roles").HasKey(c => c.Id);
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogins").HasKey(c => c.UserId);
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaims").HasKey(c => c.Id);
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRoles").HasKey(c => c.UserId);

            //modelBuilder.Entity<Customer>().HasRequired(c => c.ContractType);

            
        }
    }
}