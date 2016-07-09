﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About SFN.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Where I hang out.";

            return View();
        }
    }
}