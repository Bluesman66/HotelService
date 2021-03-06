﻿using HotelService.Models;
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
            return View();
        }

        [HttpGet]
        public ActionResult Registration()
        {
            ViewBag.Rooms = RoomRepository.GetRooms();
            return View();
        }

        [HttpPost]
        public ActionResult Registration(RegistrationForm model)
        {
            if (ModelState.IsValid)
            {
                return View("Success", model);
            }
            ViewBag.Rooms = RoomRepository.GetRooms();
            return View(model);
        }
    }
}