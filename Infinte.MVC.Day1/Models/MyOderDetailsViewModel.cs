using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infinte.MVC.Day1.Models
{
    public class MyOderDetailsViewModel
    {
        public string CustomerName { get; set; }
        public List<Products> Products { get; set; }
    }
}