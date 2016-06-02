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
            var clickedCategory = db.Categories.Where(x =>x.CategorySlug== id).Include(category => category.Products).Include(category=>category.Segments).ToList();
            return View(clickedCategory);
        }

        public ActionResult Product(string id, string productId)
        {
        
            var clickedProduct = db.Products.FirstOrDefault(x => x.ProductSlug == productId);
            ViewBag.Products = db.Products.Where(x => x.CategoryId == clickedProduct.CategoryId);
            return View("Product", clickedProduct);
        }

        public ActionResult AddDetails(int id, string Intro, string Sec1Title, string Sec1Body, string Sec2Title, string Sec2Body, string Sec3Title, string Sec3Body)
        {
            var updateCat = db.Categories.FirstOrDefault(y => y.CategoryId == id);

            updateCat.Intro = Intro;
            updateCat.Sec1Title = Sec1Title;
            updateCat.Sec1Body = Sec1Body;
            updateCat.Sec2Title = Sec2Title;
            updateCat.Sec2Body = Sec2Body;
            updateCat.Sec3Title = Sec3Title;
            updateCat.Sec3Body = Sec3Body;
            updateCat.CategoryArticle = true;

            db.SaveChanges();

            var clickedCategory = db.Categories.Where(x => x.CategoryId == id).Include(category => category.Products).Include(category=>category.Segments).ToList();
            return View("Index", clickedCategory);
        }

        public ActionResult AddSegment(int id, string Title, string Body)
        {
            var newSegment = new SegmentModel();
            newSegment.CategoryId = id;
            newSegment.SegmentTitle = Title;
            newSegment.SegmentBody = Body;
            db.Segments.Add(newSegment);
            db.SaveChanges();


            var clickedCategory = db.Categories.Where(x => x.CategoryId == id).Include(category => category.Products).Include(category => category.Segments).ToList();
            return View("Index", clickedCategory);
        }
    }
}