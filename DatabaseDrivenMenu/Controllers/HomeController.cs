using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseDrivenMenu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Database-Driven Menu Description Page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Database-Driven Contact Info.";

            return View();
        }
    }
}