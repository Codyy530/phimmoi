using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class CinematicController : Controller
    {
        // GET: Cinematic
        CinemaDB db = new CinemaDB();
        public ActionResult Cinematic()
        {
            return View();
        }
        public ActionResult Review()
        {
            ViewBag.listreview = db.Database.SqlQuery<POST>("exec GetAllReview").ToList();
            return View();
        }
        public ActionResult Blog()
        {
            ViewBag.listblog = db.Database.SqlQuery<POST>("exec GetAllBlog").ToList();
            return View();
        }
        public ActionResult Topfilm()
        {
            ViewBag.current = db.Database.SqlQuery<MOVIE>("exec GetCurrentFilm").ToList();
            return View();
        }

        public ActionResult DetailPost(string id)
        {
            var result = db.Database.SqlQuery<POST_CONTENT>($"exec GetPostContentFromPostID {id}").ToList();
            ViewBag.post = db.POSTs.Find(id);
            ViewBag.postcontent = result[0] ;
            return View();
        }


    }
}