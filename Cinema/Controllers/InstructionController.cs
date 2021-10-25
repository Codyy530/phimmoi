using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cinema.Models;
namespace Cinema.Controllers
{
    public class InstructionController : Controller
    {
        CinemaDB db = new CinemaDB();
        // GET: Instruction
        public ActionResult Instruction()
        {
            return View();
        }
    }
}