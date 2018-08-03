using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Source.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Online training system";
            return View();
        }
        // GET: About
        public ActionResult About()
        {
            ViewBag.Title = "About US";
            return View();
        }
    }
}