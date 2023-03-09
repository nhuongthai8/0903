using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Trang gioi thieu123.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Trang lien he.";

            return View();
        }
    }
}