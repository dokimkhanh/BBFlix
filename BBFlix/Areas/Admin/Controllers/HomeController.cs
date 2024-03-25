using BBFlix.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BBFlix.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {

        private BBFlixContext _context;

        public HomeController()
        {
            _context = new BBFlixContext();
        }

        // GET: Admin/Home
        public ActionResult Index()
        {
            ViewBag.MovieMonth = _context.Movie.Where(x => x.mov_date_rel.Month == DateTime.Now.Month).ToList();
            ViewBag.NewComments = _context.Reviewer.Where(x => x.rev_date.Month == DateTime.Now.Month).ToList();
            ViewBag.NewRate = _context.Reviewer.Where(x => x.rev_date.Month == DateTime.Now.Month && x.rev_star > 0).ToList();
            return View();
        }
    }
}