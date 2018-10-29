using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalkiemNowe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description pageaaaaa3333333.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact pagetest.";

            return View();
        }
    }
}