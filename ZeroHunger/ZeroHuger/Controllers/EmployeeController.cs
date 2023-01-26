using BLL.DTOs;
using BLL.Services;
using DAL.ZH_EF_CF;
using DAL.ZH_EF_CF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ZeroHuger.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [HttpGet]
        public ActionResult EmployeeList()
        {
            var empdata = Emp_info_Service.Get();
            return View(empdata);
        }

        [HttpGet]
        public ActionResult EmployeeList(int id)
        {
            var empdata = Emp_info_Service.Get(id);
            return View(empdata);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new ZeroHungerEntities();
            var emps = (from emp in db.Employee_Infos
                         where emp.ID == id
                         select emp).SingleOrDefault();

            return View(emps);
        }

        [HttpPost]
        public ActionResult Edit(Employee_info e)
        {
            var db = new ZeroHungerEntities();
            var emp = (from ed in db.Employee_Infos
                       where ed.ID == e.ID
                       select ed).SingleOrDefault();

            emp.emp_id = e.emp_id;
            emp.emp_name = e.emp_name;
            emp.emp_status = e.emp_status;
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}