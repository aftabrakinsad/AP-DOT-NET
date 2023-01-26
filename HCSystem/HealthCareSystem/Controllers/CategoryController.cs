using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HealthCareSystem.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(CatrgoryDTO cat)
        {
            CategoryService.CreateCategory(cat);
            return RedirectToAction("Dashboard");
        }
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}