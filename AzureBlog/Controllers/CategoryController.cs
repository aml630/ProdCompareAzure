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
        [ValidateInput(false)]
        public ActionResult AddDetails(int id, string Intro)
        {
            var updateCat = db.Categories.FirstOrDefault(y => y.CategoryId == id);

            updateCat.Intro = Intro;
           
            updateCat.CategoryArticle = true;

            db.SaveChanges();

            var clickedCategory = db.Categories.Where(x => x.CategoryId == id).Include(category => category.Products).Include(category=>category.Segments).ToList();
            return View("Index", clickedCategory);
        }
        [ValidateInput(false)]
        public ActionResult AddSegment(int id, string Title, string Body, string Par2, string Par3, string Image, string Video)
        {
            var newSegment = new SegmentModel();
            newSegment.CategoryId = id;
            newSegment.SegmentTitle = Title;
            newSegment.SegmentBody = Body;
            newSegment.SegmentPar2 = Par2;
            newSegment.SegmentPar3 = Par3;
            newSegment.SegmentImage = Image;
            newSegment.SegmentVideo = Video;

            db.Segments.Add(newSegment);
            db.SaveChanges();


            var clickedCategory = db.Categories.Where(x => x.CategoryId == id).Include(category => category.Products).Include(category => category.Segments).ToList();
            return View("Index", clickedCategory);
        }
    }
}