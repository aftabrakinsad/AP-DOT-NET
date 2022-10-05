using MT_ASSIGNMENT_1_Validation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MT_ASSIGNMENT_1_Validation.Controllers
{
    public class ValidationController : Controller
    {
        // GET: Validation
        public ActionResult Validationf1(Validation valid)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(valid);
        }
    }
}