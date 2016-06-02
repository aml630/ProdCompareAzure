using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Mvc.Routing.Constraints;


namespace AzureBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "About",
                url: "About",
                defaults: new { controller = "Home", action = "About" }
            );

            routes.MapRoute(
              name: "Product",
              url: "{id}/{productId}",
              defaults: new { controller = "Category", action = "Product" }
              //constraints: new { id = @"([a-z]+-?)+", productId = @"([a-z]+-?)+" }
          );

            routes.MapRoute(
               name: "Category",
               url: "{id}",
               defaults: new { controller = "Category", action = "Index" }
               //constraints: new {id = @"([a-z]+-?)+" }
           );

            routes.MapRoute(
              name: "Default",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
          );

        }
    }
}
