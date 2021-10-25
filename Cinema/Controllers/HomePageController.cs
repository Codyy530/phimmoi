using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;
namespace Cinema.Controllers
{
    public class HomePageController : Controller
    {
        CinemaDB db = new CinemaDB();
        // GET: HomePage
        public ActionResult HomePage()
        {
            var movie = db.MOVIEs.ToList();
            ViewBag.movie = movie;
            var blp = db.Database.SqlQuery<POST>("exec GetReview").ToList();
            var blog = db.Database.SqlQuery<POST>("exec GetBlog").ToList();
            var sale = db.Database.SqlQuery<POST>("exec GetSaleNew").ToList();
            ViewBag.blp = blp;
            ViewBag.blog = blog;
            ViewBag.sale = sale;
            return View();
        }
        public ActionResult Details(string id)
        {
            ViewBag.detail=db.MOVIEs.Find(id);
            return View();
        }
    }
}