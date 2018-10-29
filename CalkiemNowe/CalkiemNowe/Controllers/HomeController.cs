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
            ViewBag.Message = "Your application description page.22222222221aaaaaaaa";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.1111111111111111";

            return View();
        }
    }
}