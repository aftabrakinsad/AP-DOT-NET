using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ZeroHunger.Database;

namespace Mid.Controllers
{
    public class RestrurantsController : Controller
    {
        private readonly ZeroHungerEntities2 db = new ZeroHungerEntities2();
        public ActionResult Index()
        {
            var db = new ZeroHungerEntities2();
            var emp = db.Restrurants.ToList();
            return View(emp);
        }

        public ActionResult Details(string id)
        {
            var db = new ZeroHungerEntities2();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Restrurant restrurant = db.Restrurants.Find(id);
            if (restrurant == null)
            {
                return HttpNotFound();
            }

            return View(restrurant);
        }

        public ActionResult Create()
        {
            ViewBag.Food_typeid = new SelectList(db.Foods, "Id", "Type");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,res_id,storate_time,Food_typeid")] Restrurant restrurant)
        {
            if (ModelState.IsValid)
            {
                db.Restrurants.Add(restrurant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Food_typeid = new SelectList(db.Foods, "Id", "Type", restrurant.Food_typeid);
            return View(restrurant);
        }

        [HttpGet]
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Restrurant restrurant = db.Restrurants.Find(id);
            if (restrurant == null)
            {
                return HttpNotFound();
            }
            ViewBag.Food_typeid = new SelectList(db.Foods, "Id", "Type", restrurant.Food_typeid);
            return View(restrurant);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Name,res_id,storage_time,Food_typeid")] Restrurant restrurant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(restrurant).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Food_typeid = new SelectList(db.Foods, "Id", "Type", restrurant.Food_typeid);
            return View(restrurant);
        }

        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Restrurant restrurant = db.Restrurants.Find(id);
            if (restrurant == null)
            {
                return HttpNotFound();
            }
            return View(restrurant);
        }

        // POST: Restrurants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Restrurant restrurant = db.Restrurants.Find(id);
            db.Restrurants.Remove(restrurant);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult FoodStorage(Food f)
        {
            var db = new ZeroHungerEntities2();
            var foods = (from fd in db.Restrurants
                         where fd.Name == "Kfc"
                         select fd).ToList();

            return View(foods);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}