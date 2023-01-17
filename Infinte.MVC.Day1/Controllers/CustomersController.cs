using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Infinte.MVC.Day1.Controllers
{
    [RoutePrefix("Customers")]
    public class CustomersController : Controller
    {
        

        // GET: Customers
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCustomer(int id)
        {
            return Content($"Customer Id : {id}");
        }

        //Customers/GetCustomerByIdAndName/1001/Santhosh
        [Route("GetCustomerByIdAndName/{id}/{name}")]
        public ActionResult GetCustomerByIdAndName(int? id, string name)
        {
            if(id.HasValue || !string.IsNullOrEmpty(name))
            {
                return Content($"Id :{id.Value}\n Name :{name}");
            }
            else
            {
                return Content("Please provide Id or Name");
            }
        }

        [Route("GetCustomerByName/{name}")]
        public ActionResult GetCustomerByName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                return Content($"Welcome, {name}");
            }
            else
            {
                return Content("Please Provide Name");
            }
        }

        [Route("GetPerson/{name}/{gender}/{dob}")]
        public ActionResult GetPerson(string name,char gender,DateTime dob)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                return Content($"Name :{name}\tGender :{gender}\tDateOfBirth : {dob}");
            }
            else
            {
                return Content("Please Provide name");
            }
        }

    }
}