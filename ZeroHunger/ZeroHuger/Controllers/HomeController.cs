using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZeroHuger.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult EmployeeLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EmployeeLogin(Employee_loginDTO emplog)
        {
            var emp = Emp_Log_Service.Get(emplog.emp_id);
            if (emp != null)
            {
                if (emp.emp_pass.Equals(emplog.emp_pass))
                {
                    Session["logged"] = emp.emp_id;
                    Session["logged"] = emp.emp_pass;
                    return RedirectToAction("EmployeeList", "Employee");
                }
            }
            TempData["msg"] = "Invalid ID or Password";
            return RedirectToAction("EmployeeLogin");
        }

        [HttpGet]
        public ActionResult CompanyLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CompanyLogin(Company_loginDTO comlog)
        {
            var com = Com_Log_Service.Get(comlog.com_id);
            if (com != null)
            {
                if (com.com_pass.Equals(comlog.com_pass))
                {
                    Session["logged"] = com.com_id;
                    Session["logged"] = com.com_pass;
                    return RedirectToAction("Index", "Home");
                }
            }
            TempData["msg"] = "Invalid ID or Password";
            return RedirectToAction("CompanyLogin");
        }

        [HttpGet]
        public ActionResult RestaurantLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RestaurantLogin(Restaurant_loginDTO reslog)
        {
            var res = Res_Log_Service.Get(reslog.res_id);
            if (res != null)
            {
                if (res.res_pass.Equals(reslog.res_pass))
                {
                    Session["logged"] = res.res_id;
                    Session["logged"] = res.res_pass;
                    return RedirectToAction("Index", "Home");
                }
            }
            TempData["msg"] = "Invalid ID or Password";
            return RedirectToAction("RestaurantLogin");
        }
    }
}