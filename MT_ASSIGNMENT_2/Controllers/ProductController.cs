using MT_ASSIGNMENT_2.Database;
using MT_ASSIGNMENT_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MT_ASSIGNMENT_2.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            var database = new MID_ASSIGNMENT_TWOEntities();
            var Products = database.Products.ToList();
            return View(Products);
        }

        [HttpGet]
        public ActionResult Products()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Products(Product ppt)
        {
            var database = new MID_ASSIGNMENT_TWOEntities();
            database.Products.Add(ppt);
            database.SaveChanges();
            return RedirectToAction("Products");
        }

        /*[HttpPost]
        public ActionResult Products(Validation valid)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Products");
            }
            return View(valid);
        }*/

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var database = new MID_ASSIGNMENT_TWOEntities();
            var ext = (from pt in database.Products
                       where pt.ID == ID
                       select pt).SingleOrDefault();
            return View(ext);
        }

        [HttpPost]
        public ActionResult Edit(Product p)
        {
            var database = new MID_ASSIGNMENT_TWOEntities();
            var ext = (from pt in database.Products
                       where pt.ID == p.ID
                       select pt).SingleOrDefault();
            ext.Name = p.Name;
            ext.Price = p.Price;
            ext.Qty = p.Qty;
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
            using (var database = new MID_ASSIGNMENT_TWOEntities())
            {
                var pd = database.Products.FirstOrDefault(x => x.ID == ID);
                database.Products.Remove(pd);
                database.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public ActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Checkout(Product p)
        {
            var database = new MID_ASSIGNMENT_TWOEntities();
            var ext = (from pt in database.Products
                       where pt.ID == p.ID
                       select pt).SingleOrDefault();
            ext.Name = p.Name;
            ext.Price = p.Price;
            ext.Qty = p.Qty;
            database.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult ProductList()
        {
            List<Product> Products = new List<Product>();
            for (int i = 1; i <= 10; i++)
            {
                var p1 = new Product()
                {
                    ID = i,
                    Name = "Product " + i,
                    Price = 250,
                    Qty = 1
                };
                Products.Add(p1);
            }
            return View(Products);
        }
    }
    }
}