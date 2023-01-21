using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZeroHuger.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult EmployeeLogin()
        {
            return View();
        }

        public ActionResult Restaurant()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Company()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}