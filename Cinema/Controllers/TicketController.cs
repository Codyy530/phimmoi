using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;
namespace Cinema.Controllers
{
    public class TicketController : Controller
    {
        CinemaDB db = new CinemaDB();
        // GET: Ticket
        [HttpPost]
        public JsonResult SelectTicket(string cinemaname, string cinemaaddress, string showtime, string screentype, string filmname)
        {
            ViewBag.CinemaAddress = cinemaname;
            ViewBag.CinemaName = cinemaaddress;
            ViewBag.FilmName = filmname;
            ViewBag.showtime = showtime;
            ViewBag.screentype = screentype;
            return Json("dd");
        }
        public ActionResult SelectSeat()
        {
            return View();
        }
        public ActionResult SelectService()
        {
            return View();
        }
        public ActionResult Payment()
        {
            return View();
        }

    }
}