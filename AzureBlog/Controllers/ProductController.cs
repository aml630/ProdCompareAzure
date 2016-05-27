using AzureBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureBlog.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Product
        public ActionResult Index(int id)
        {
            var clickedProduct = db.Products.FirstOrDefault(x => x.ProductId == id);
            ViewBag.Products = db.Products.Where(x => x.CategoryId == clickedProduct.CategoryId);
            return View(clickedProduct);
        }
    }
}