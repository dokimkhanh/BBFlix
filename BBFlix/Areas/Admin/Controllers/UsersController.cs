using BBFlix.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BBFlix.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        private readonly BBFlixContext _context;

        public UsersController()
        {
            _context = new BBFlixContext();
        }

        // GET: Admin/Users
        public ActionResult Index()
        {
            var users = _context.User.ToList();
            return View(users);
        }

        public ActionResult Edit()
        {
            return View();
        }
    }
}