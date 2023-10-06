using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class CustomerDBContext:DbContext
    {
        public DbSet<Customer> customers { get; set; }
        public DbSet<Order> orders { get;set; }

        public DbSet<Product> products { get; set; }

        public DbSet<Supplier> suppliers { get; set; }





    }
}