using CrudApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CrudApplication.EF
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("ProductConnSt")
        {
                
        }

        public DbSet<Product> Products { get; set; }
    }
}