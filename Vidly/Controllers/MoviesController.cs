﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Microsoft.Ajax.Utilities;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller{
        private ApplicationDbContext _context;

        public MoviesController(){
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing){
            base.Dispose(disposing);
            _context.Dispose();
        }

        // GET: Movies
        public ActionResult Index(){

            var movies = _context.Movies.Include(m => m.Genre);
           
            
            return View(movies);
        }

        public ActionResult Details(int id){

            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);
            return View(movie);
        }
    }
}