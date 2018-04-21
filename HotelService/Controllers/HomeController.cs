using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.VisitorNumber = new Random().Next(1, 100);
            ViewBag.DateAndTime = DateTime.Now;
            ViewData["VisitorNumber"] = new Random().Next(1, 100);
            return View();
        }
    }
}