using System;
using shoppingwithme.Database;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoppingwithme.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Letsdoshop()
        {
            var database = new shoppingwithmeEntities();
            var Product = database.products.ToList();
            return View(Product);
        }
    }
}