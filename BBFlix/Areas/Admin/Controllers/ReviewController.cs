using BBFlix.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BBFlix.Areas.Admin.Controllers
{
    public class ReviewController : Controller
    {
        private readonly BBFlixContext _context;

        public ReviewController()
        {
            _context = new BBFlixContext();
        }

        // GET: Admin/Review
        public ActionResult Index()
        {
            var revs = _context.Reviewer.ToList();
            return View(revs);
        }
    }
}