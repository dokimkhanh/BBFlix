using BBFlix.Models.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BBFlix.Common;

namespace BBFlix.Areas.Admin.Controllers
{
    public class GenreController : Controller
    {
        private readonly BBFlixContext _context;

        public GenreController()
        {
            _context = new BBFlixContext();
        }

        // GET: Admin/Catalog
        public ActionResult Index()
        {
            var gens = _context.Genres.ToList();
            return View(gens);
        }

        public ActionResult Add()
        {
            return View();
        }


        public ActionResult Edit(int id)
        {
            var genre = _context.Genres.FirstOrDefault(x => x.gen_id == id);
            return View(genre);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Genres model)
        {
            var genre = _context.Genres.Where(x => x.gen_id == model.gen_id).FirstOrDefault();
            if (genre != null)
            {
                genre.gen_title = model.gen_title;
                genre.gen_slug = SlugHelper.GetSlug(model.gen_title);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Genres model)
        {
            model.gen_slug = SlugHelper.GetSlug(model.gen_title);
            _context.Genres.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                var checkExists = _context.Genres.FirstOrDefault(x => x.gen_id == id);
                if (checkExists != null)
                {
                    _context.Genres.Remove(checkExists);
                    _context.SaveChanges();
                    return Json(new { success = true });
                }
                else
                {
                    return Json(new { success = false, errorMessage = "Genre not found." });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, errorMessage = ex.Message });
            }
        }

    }
}