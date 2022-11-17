using StudentManagement.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagement.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var database = new StudentManagementEntities();
            var students = database.Students.ToList();
            return View(students);
        }

        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(Student ast)
        {
            var database = new StudentManagementEntities();
            database.Students.Add(ast);
            database.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditStudent(int id)
        {
            var database = new StudentManagementEntities();
            var edit = (from st in database.Students
                        where st.Id == id
                        select st).SingleOrDefault();
            return View(edit);
        }

        [HttpPost]
        public ActionResult EditStudent(Student editstudent)
        {
            var database = new StudentManagementEntities();
            var edit = (from st in database.Students
                        where st.Id == editstudent.Id
                        select st).SingleOrDefault();
            edit.Name = editstudent.Name;
            edit.Dob = editstudent.Dob;
            return RedirectToAction("Index");
        }
    }
}