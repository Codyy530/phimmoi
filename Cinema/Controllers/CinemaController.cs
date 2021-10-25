using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;
namespace Cinema.Controllers
{
    public class CinemaController : Controller
    {
        CinemaDB db = new CinemaDB();
        // GET: Cinema
        public ActionResult Cinema(string location, string cinemaname, string change)
        {
            ViewBag.listlocation = db.CINEMA_LOCATION.ToList();
            if (location != "none")
            {
                ViewBag.listcinema = db.Database.SqlQuery<CINEMA>($"exec GetListCinemaFromLocation N'{location}'").ToList();
                if (cinemaname != "none")
                {
                    var result = db.Database.SqlQuery<CINEMA>($"exec GetListCinemaFromName N'{cinemaname}'").ToList();
                    ViewBag.cinemax = result[0];
                    ViewBag.listmovie= db.Database.SqlQuery<MovieItem>($"exec GetListFilmFromCinema N'{cinemaname}','2021-10-25'").ToList();
                    foreach (var item in ViewBag.listmovie)
                    {
                        item.type1 = db.Database.SqlQuery<ShowTime>($"exec GetList2DRoomFromFilm N'{cinemaname}',N'{item.MovieName}', N'2021-10-25'").ToList();
                        item.type2 = db.Database.SqlQuery<ShowTime>($"exec GetList3DRoomFromFilm N'{cinemaname}',N'{item.MovieName}', N'2021-10-25'").ToList();
                        item.type3 = db.Database.SqlQuery<ShowTime>($"exec GetList4DRoomFromFilm N'{cinemaname}',N'{item.MovieName}', N'2021-10-25'").ToList();
                    }
                    ViewBag.cinemaimg = db.Database.SqlQuery<CINEMA_IMAGE>($"exec GetListImgFromCinema N'{cinemaname}'").ToList();
                }
            }
           
            ViewBag.checklocation = location;
            ViewBag.checkcinema = cinemaname;
            ViewBag.change = change;
            return View();
        }
        

    }
}