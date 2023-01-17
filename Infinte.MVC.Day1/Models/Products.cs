using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infinte.MVC.Day1.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public List<Products> GetProducts()
        {
            return new List<Products> {
            new Products() { Id = 101, ProductName = "Pen", Price = 10, Quantity = 100 },
            new Products() { Id = 102, ProductName = "Bottle", Price = 40, Quantity = 150 },
            new Products() { Id = 103, ProductName = "Book", Price = 20, Quantity = 200 },
            new Products() { Id = 104, ProductName = "Bag", Price = 200, Quantity = 10 }
        };
        }
    }
}