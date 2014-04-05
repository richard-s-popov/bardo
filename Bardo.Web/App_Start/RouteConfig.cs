using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Bardo.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Sets", // Route name
                "Наборы-суши", // URL with parameters
                new { controller = "Home", action = "Sets" } // Parameter defaults
            );

            routes.MapRoute(
                "Actions", // Route name
                "Акции", // URL with parameters
                new { controller = "Home", action = "Actions" } // Parameter defaults
            );

            routes.MapRoute(
                "Rolls", // Route name
                "Роллы", // URL with parameters
                new { controller = "Home", action = "Rolls" } // Parameter defaults
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}