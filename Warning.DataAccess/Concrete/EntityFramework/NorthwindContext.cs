using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Warning.Northwind.Entities.Concrete;

namespace Warning.Northwind.DataAccess.Concrete.EntityFramework
{
  public  class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)/mssqllocaldb;Database=Northwind; Trusted_Connection=true");

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
