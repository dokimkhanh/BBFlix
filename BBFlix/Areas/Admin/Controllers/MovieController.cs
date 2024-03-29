﻿using BBFlix.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BBFlix.Areas.Admin.Controllers
{
    public class MovieController : Controller
    {

        private BBFlixContext _context;

        public MovieController()
        {
            _context = new BBFlixContext();
        }
        // GET: Admin/Catalog
        public ActionResult Index()
        {
            var movies = _context.Movie.ToList();
            return View(movies);
        }
    }
}