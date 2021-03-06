﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller{
        private ApplicationDbContext _context;

        public CustomersController(){
            _context = new ApplicationDbContext();

        }

        protected override void Dispose(bool disposing){
            base.Dispose(disposing);
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index(){

            var customers = _context.Customers.Include(c => c.MembershipType);

            return View(customers);
        }


        public ActionResult Details(int id){
            Console.WriteLine("A");
            var customers = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customers == null){
                return HttpNotFound();
            }

            return View(customers);
        }


    }

    
}