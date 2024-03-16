using BBFlix.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BBFlix.Controllers
{
    public class MovieController : Controller
    {
        private readonly BBFlixContext _context;

        public MovieController()
        {
            _context = new BBFlixContext();
        }
        // GET: Movie
        public ActionResult Index(int id)
        {
            var movie = _context.Movie.Where(x => x.mov_id == id).FirstOrDefault();
            return View(movie);
        }
    }
}