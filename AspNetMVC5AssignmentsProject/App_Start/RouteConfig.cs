using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace AspNetMVC5AssignmentsProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Person",
                url: "{controller}/{action}/{id1}/{id2}/{id3}",
                defaults: new { controller = "Person", action = "Index", id1 = UrlParameter.Optional, id2 = UrlParameter.Optional, id3 = UrlParameter.Optional });


            routes.MapRoute(
                name: "Maths",
                url: "{controller}/{action}/{id1}/{id2}",
                defaults: new { controller = "Math", action = "Index", id1 = UrlParameter.Optional, id2 = UrlParameter.Optional });


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
