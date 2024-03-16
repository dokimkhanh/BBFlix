using BBFlix.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BBFlix.Controllers
{
    public class HomeController : Controller
    {
        private readonly BBFlixContext _context;

        public HomeController()
        {
            _context = new BBFlixContext();
        }

        public ActionResult Index()
        {
            var topMovie = _context.Movie.Take(10).OrderBy(x => x.mov_date_rel).ToList();
            return View(topMovie);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}