using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WallSite.DataAccess;

namespace WallSite.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (var context = new WallContext())
            {
                var comments = context.Comments.ToList();
                ViewBag.Comments = comments;
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(string user, string text)
        {
            using (var context = new WallContext())
            {
                context.Comments.Add(new Models.Comment() { Text= text, User = user });
                context.SaveChanges();
                ViewBag.Comments = context.Comments.ToList();
            }

            return Json(new { user, text });
        }
    }
}