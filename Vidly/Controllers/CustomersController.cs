using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        Customer[] customers = {
            new Customer{Name = "John Smith", Id = 1},
            new Customer{Name = "mary Williams", Id = 2}
        };
        // GET: Customers
        public ActionResult Index(){

            return View(customers);
        }


        public ActionResult Details(int id){

            if (id <= 0 || id > customers.Length){
                return HttpNotFound();
            }

            return View(customers[id-1]);
        }
}

    
}