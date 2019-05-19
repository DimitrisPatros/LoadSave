using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BasketManagment
{
    class OrderManagmentDbContext : DbContext
    {
        internal readonly object customer;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server = localhost;Database=OrderManagment; Trusted_Connection = True; ConnectRetryCount = 0;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Basket>();
            modelBuilder.Entity<Product>();
            modelBuilder.Entity<Customer>().HasIndex(u => u.Name).IsUnique();

        }
    }

    //run in supershell 
    //dotnet ef migrations add initial-create
    //dotnet ef database update
}
