using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.Database;
using static System.Net.Mime.MediaTypeNames;

namespace Mid.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var db = new ZeroHungerEntities2();
            var emp = db.Employees.ToList();
            return View(emp);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new ZeroHungerEntities2();

            var foods = (from fd in db.Employees
                         where fd.Id == id
                         select fd).SingleOrDefault();

            return View(foods);
        }
        [HttpPost]
        public ActionResult Edit(Employee e)
        {

            var db = new ZeroHungerEntities2();
            var emp = (from ed in db.Employees
                       where ed.Id == e.Id
                       select ed).SingleOrDefault();
            emp.Name = e.Name;
            emp.Dob = e.Dob;
            emp.Gender = e.Gender;
            emp.Status = e.Status;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var db = new ZeroHungerEntities2();

            var foods = (from fd in db.Employees
                         where fd.Id == id
                         select fd).SingleOrDefault();

            return View(foods);
        }
        [HttpGet]
        public ActionResult Delete(int Id)
        {
            var db = new ZeroHungerEntities2();
            var foods = (from fd in db.Employees
                         where fd.Id == Id
                         select fd).SingleOrDefault();
            return View(foods);
        }
        [HttpPost]
        public ActionResult Delete(Employee f)
        {

            var db = new ZeroHungerEntities2();

            var foods = (from fd in db.Employees

                         where fd.Id == f.Id

                         select fd).SingleOrDefault();

            db.Employees.Remove(foods);

            db.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {

            var db = new ZeroHungerEntities2();
            emp.Status = "Free";
            db.Employees.Add(emp);
            db.SaveChanges();

            return RedirectToAction("Index");

        }


        public ActionResult Collect(Food f)
        {
            var db = new ZeroHungerEntities2();
            var foods = (from fd in db.Foods
                         where fd.Status == "Pending"
                         select fd).ToList();

            return View(foods);
        }


        [HttpGet]
        public ActionResult Assigned(int id)
        {
            var db = new ZeroHungerEntities2();
            List<Employee> employees = db.Employees.ToList();
            ViewBag.Employees = employees;
            var foods = (from fd in db.Foods
                         where fd.Id == id
                         select fd).SingleOrDefault();

            return View(foods);
        }
        [HttpPost]

        public ActionResult Assigned(Food f)
        {

            var db = new ZeroHungerEntities2();
            List<Employee> employees = db.Employees.ToList();
            ViewBag.Employees = employees;

            var foods = (from fd in db.Foods
                         where fd.Id == f.Id
                         select fd).SingleOrDefault();
            foods.Type = f.Type;
            foods.Time = f.Time;
            foods.Status = "Assigned";
            foods.EmpId = f.EmpId;
            db.SaveChanges();

            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Reject(int id)
        {
            var db = new ZeroHungerEntities2();
            List<Employee> employees = db.Employees.ToList();
            ViewBag.Employees = employees;
            var foods = (from fd in db.Foods
                         where fd.Id == id
                         select fd).SingleOrDefault();
            return View(foods);

        }

        public ActionResult Complete(Food f)
        {
            var db = new ZeroHungerEntities2();
            var foods = (from fd in db.Foods
                         where fd.Status == "Assigned"
                         select fd).ToList();

            return View(foods);
        }

        public ActionResult Completed(Food f)
        {
            var db = new ZeroHungerEntities2();
            var foods = (from fd in db.Foods
                         where fd.Id == f.Id &&
                         fd.Status == "Collected"
                         select fd).SingleOrDefault();
            foods.Status = "Distributed";
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Distribute()
        {
            var db = new ZeroHungerEntities2();
            var foods = (from fd in db.Foods
                         where fd.Status == "Distributed"
                         select fd).ToList();

            return View(foods);
        }
        public ActionResult OrderDetails(int id)
        {
            var db = new ZeroHungerEntities2();

            var foods = (from fd in db.Foods
                         where fd.Id == id
                         select fd).SingleOrDefault();

            return View(foods);
        }
        public ActionResult DeleteOrder(int Id)
        {
            var db = new ZeroHungerEntities2();

            var foods = (from fd in db.Foods
                         where fd.Id == Id
                         select fd).SingleOrDefault();
            return View(foods);
        }
        [HttpPost]
        public ActionResult DeleteOrder(Food f)
        {

            var db = new ZeroHungerEntities2();

            var foods = (from fd in db.Foods

                         where fd.Id == f.Id

                         select fd).SingleOrDefault();

            db.Foods.Remove(foods);

            db.SaveChanges();

            return RedirectToAction("Index");
        }





    }
}