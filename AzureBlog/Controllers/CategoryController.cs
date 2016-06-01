using AzureBlog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AzureBlog.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Category
        public ActionResult Index(string id)
        {
            var clickedCategory = db.Categories.Where(x =>x.CategoryName== id).Include(category => category.Products).ToList();
            return View(clickedCategory);
        }

        public ActionResult Product(string id, string productId)
        {
        
            var clickedProduct = db.Products.FirstOrDefault(x => x.ProductName == productId);
            ViewBag.Products = db.Products.Where(x => x.CategoryId == clickedProduct.CategoryId);
            return View("Product", clickedProduct);
        }
    }
}