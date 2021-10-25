using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Cinema.Models;
namespace Cinema.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        CinemaDB db = new CinemaDB();
        public ActionResult Search()
        {
            string keyword = Request.Form["keyword"];
            SqlParameter x = new SqlParameter();
            x.Value = keyword;
            var result = db.Database.SqlQuery<MOVIE>($"exec SearchFilm @name=N'{x.Value}'");
            ViewBag.result = result;
            ViewBag.keyword = x.Value;
            
            return View();
        }
        
    }
}