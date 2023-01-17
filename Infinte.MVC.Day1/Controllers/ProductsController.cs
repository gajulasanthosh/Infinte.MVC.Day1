using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Infinte.MVC.Day1.Models;

namespace Infinte.MVC.Day1.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context = null;

        public ProductsController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Products
        public ActionResult Index()
        {
            //Products prop = new Products();
            //List<Products> products = prop.GetProducts();
            var products = _context.Products.ToList();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            //Products productsObj = new Products();
            //var product = productsObj.GetProducts().FirstOrDefault(c => c.Id == id);
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                return View(product);
            }
            return HttpNotFound();
        }
    }
}