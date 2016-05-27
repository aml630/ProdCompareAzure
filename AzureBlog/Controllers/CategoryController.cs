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
        public ActionResult Index(int id)
        {
            var clickedCategory = db.Categories.Where(x =>x.CategoryId== id).Include(category => category.Products).ToList();
            return View(clickedCategory);
        }
    }
}