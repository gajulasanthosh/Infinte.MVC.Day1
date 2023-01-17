using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Infinte.MVC.Day1.Models
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext() : base("Mycon")
        {

        }

        //Table Mapping
        public DbSet<Products> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}