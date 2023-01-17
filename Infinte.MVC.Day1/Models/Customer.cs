using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infinte.MVC.Day1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNo { get; set; }

        public List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer() {Id=1001,Name= "Santhosh",MobileNo="6302939043"},
                new Customer() {Id=1002,Name= "Sunny",MobileNo="7302939052"},
                new Customer() {Id=1003,Name= "Sruthi",MobileNo="8302939043"},
                new Customer() {Id=1004,Name= "Priya",MobileNo="9302939043"}
            };
        }
    }
}