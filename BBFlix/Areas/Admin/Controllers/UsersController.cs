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

        public ActionResult Add()
        {
            ViewBag.Plans = new SelectList(_context.Plan.ToList(), "plan_id", "plan_name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(User model)
        {
            if (ModelState.IsValid)
            {
                model.user_date = DateTime.Now;
                model.user_status = true;
                _context.User.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Plans = new SelectList(_context.Plan.ToList(), "plan_id", "plan_name");
            return View();
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Plans = new SelectList(_context.Plan.ToList(), "plan_id", "plan_name");
            var user = _context.User.Where(x => x.user_id == id).FirstOrDefault();
            if (user != null)
            {
                return View(user);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(User model)
        {
            ViewBag.Plans = new SelectList(_context.Plan.ToList(), "plan_id", "plan_name");
            var user = _context.User.Where(x => x.user_id == model.user_id).FirstOrDefault();
            if (user != null)
            {
                user.user_fullname = model.user_fullname;
                user.user_email = model.user_email;
                user.user_avatar = model.user_avatar;
                user.user_pass = model.user_pass;
                user.user_plan = model.user_plan;
                user.user_role = model.user_role;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult ChangeStatus(int id)
        {
            var user = _context.User.Where(x => x.user_id == id).FirstOrDefault();
            user.user_status = !user.user_status;
            _context.SaveChanges();
            return Redirect(Request.UrlReferrer.ToString());

        }
    }
}