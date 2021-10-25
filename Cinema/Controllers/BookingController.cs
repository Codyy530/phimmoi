using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;
namespace Cinema.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        CinemaDB db = new CinemaDB();
        public ActionResult Booking(string name, string location)
        {
            SqlParameter moviename = new SqlParameter();
            moviename.Value = name;
            ViewBag.movie = db.Database.SqlQuery<MOVIE>("exec GetCurrentFilm").ToList();
            ViewBag.LC = db.CINEMA_LOCATION.ToList();
            if (location == "all")
            {
                ViewBag.cinema = db.Database.SqlQuery<CinemaItem1>($"exec GetListCinemaFromFilm N'{name}', N'2021-10-25'").ToList();
            }
            else
            {
                ViewBag.cinema = db.Database.SqlQuery<CinemaItem1>($"exec GetListCinemaFromFilmAndLocation N'{name}', N'2021-10-25',N'{location}'").ToList();
            }
            
            foreach (var item in ViewBag.cinema)
            {
                
                
              item.type1 = db.Database.SqlQuery<ShowTime>($"exec GetList2DRoomFromFilm N'{item.CinemaName}',N'{name}', N'2021-10-25'").ToList();
                item.type2 = db.Database.SqlQuery<ShowTime>($"exec GetList3DRoomFromFilm N'{item.CinemaName}',N'{name}', N'2021-10-25'").ToList();
                item.type3 = db.Database.SqlQuery<ShowTime>($"exec GetList4DRoomFromFilm N'{item.CinemaName}',N'{name}', N'2021-10-25'").ToList();
             
            }
           
            ViewBag.check = name;
            ViewBag.location = location;
            return View();
        }
    }
}