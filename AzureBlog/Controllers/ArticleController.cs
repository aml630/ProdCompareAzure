using AzureBlog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace AzureBlog.Controllers
{
    public class ArticleController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Category
        public ActionResult Post(string articleSlug)
        {

            var article = db.Articles.Where(x => x.ArticleSlug == articleSlug).Include(x => x.ArticleSegments).ToList();

            return View(article);
        }
        public ActionResult CreateArticle(string name, string slug)
        {
            var article = new ArticleModel();
            article.ArticleName = name;
            article.ArticleSlug = slug;
            article.ArticlePic = "http://cats.com/wp-content/uploads/2016/01/1200x280.jpg";
            article.ArticlePublished = false;
            article.Intro = "intro";
            article.FbShares = 0;
            article.TwitShares = 0;
            db.Articles.Add(article);

            db.SaveChanges();


            return RedirectToAction("Index", "Home");
        }

        public ActionResult AddSegment(int id, string Title, string Body, string Par2, string Par3, string Image, string Video, string ArticleSlug)
        {
            var newSegment = new ArticleSegmentModel();
            newSegment.ArticleId = id;
            newSegment.ArticleSegmentTitle = Title;
            newSegment.ArticleSegmentPar1 = Body;
            newSegment.ArticleSegmentPar2 = Par2;
            newSegment.ArticleSegmentPar3 = Par3;
            newSegment.ArticleSegmentImage = Image;
            newSegment.ArticleSegmentVideo = Video;

            db.ArticleSegment.Add(newSegment);
            db.SaveChanges();

            var article = db.Articles.Where(x => x.ArticleSlug == ArticleSlug).Include(x => x.ArticleSegments).ToList();


            return View("Post", article);
        }



    }
}