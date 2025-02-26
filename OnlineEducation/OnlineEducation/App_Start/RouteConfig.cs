﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OnlineEducation
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
              name: "trang-chu",
              url: "home",
              defaults: new { controller = "Home", action = "Index" }
            );

            routes.MapRoute(
              name: "category",
              url: "category",
              defaults: new { controller = "Home", action = "Category" }
          );

            routes.MapRoute(
               name: "contact",
               url: "contact",
               defaults: new { controller = "Home", action = "Contact" }
           );


            routes.MapRoute(
                name: "logout",
                url: "logout",
                defaults: new { controller = "Home", action = "Logout" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
