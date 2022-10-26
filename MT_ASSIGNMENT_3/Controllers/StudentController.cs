using System;
using MT_ASSIGNMENT_3.Database;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MT_ASSIGNMENT_3.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            var database = new MId_ASSIGNMENT_THREEEntities2();
            var Students = database.Students.ToList();
            return View(Students);
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var database = new MId_ASSIGNMENT_THREEEntities2();
            var ext = (from pt in database.Students
                       where pt.Id == Id
                       select pt).SingleOrDefault();
            return View(ext);
        }

        [HttpPost]
        public ActionResult Edit(Student s)
        {
            var database = new MId_ASSIGNMENT_THREEEntities2();
            var ext = (from pt in database.Students
                       where pt.Id == s.Id
                       select pt).SingleOrDefault();
            ext.Name = s.Name;
            ext.Cgpa = s.Cgpa;
            database.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int ID)
        {
            using (var database = new MId_ASSIGNMENT_THREEEntities2())
            {
                var pd = database.Students.FirstOrDefault(x => x.ID == ID);
                database.Students.Remove(pd);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
        }
    }
}