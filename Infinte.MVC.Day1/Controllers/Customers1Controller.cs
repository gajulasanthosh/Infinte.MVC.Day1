using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Infinte.MVC.Day1.Models;

namespace Infinte.MVC.Day1.Controllers
{
    public class Customers1Controller : Controller
    {
        private readonly ApplicationDbContext _context = null;

        public Customers1Controller()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Customers1
        public ActionResult Index()
        {
            //Customer customer = new Customer();
            //List<Customer> customers = customer.GetCustomers();
            var customers = _context.Customers.ToList();
            return View(customers);
        }   

        public ActionResult Details(int id)
        {
            //Customer customerObj = new Customer();
            //var customer = customerObj.GetCustomers().FirstOrDefault(c => c.Id == id);
            var customer = _context.Customers.FirstOrDefault(p => p.Id == id);
            if (customer != null)
            {
                return View(customer);
            }
            else
            {
                return HttpNotFound();
            }
        }

        //Customers1/MyOrders/id
        public ActionResult MyOrders(int id)
        {
            Products p = new Products();
            //MyOderDetailsViewModel vm = new MyOderDetailsViewModel()
            //{
            //    //CustomerName = "Jai",
            //    //CustomerName = new Customer().GetCustomers().FirstOrDefault(c => c.Id == 1001).Name,
            //    CustomerName = new Customer().GetCustomers().FirstOrDefault(c => c.Id == id).Name,
            //    Products = new Products().GetProducts()
            //    //or  Products = p.GetProducts()
            //};

            MyOderDetailsViewModel vm = new MyOderDetailsViewModel();
            //vm.CustomerName = new Customer().GetCustomers().FirstOrDefault(c => c.Id == id)?.Name;
            vm.CustomerName = _context.customers.FirstOrDefault(c => c.Id == id)?.Name;
            if(vm.CustomerName == null)
            {
                return HttpNotFound("Customer Id doesn't exists");
            }
            vm.Products = new Products().GetProducts();

            return View(vm);
        }
        
    }
}