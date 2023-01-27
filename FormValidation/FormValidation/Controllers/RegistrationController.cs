using FormValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormValidation.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserValidation user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success", "Registration");
            }
            return View(user);
        }
        public ActionResult Success()
        {
            return View();
        }
    }
}