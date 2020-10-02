using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace luceMIS4200demo2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "A.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Ways to contact Luce.";

            return View();
        }
    }
}