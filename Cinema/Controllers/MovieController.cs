using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;
namespace Cinema.Controllers
{
    
    public class MovieController : Controller
    {
        CinemaDB db = new CinemaDB();
        // GET: Movie
        public ActionResult MovieCurrent()
        {
            var current = db.Database.SqlQuery<MOVIE>("exec GetCurrentFilm").ToList();
            ViewBag.current = current;
            return View();
        }
        public ActionResult MovieFeature()
        {
            var future = db.Database.SqlQuery<MOVIE>("exec GetFeatureFilm").ToList();
            ViewBag.future = future;
            return View();
        }
    }
}