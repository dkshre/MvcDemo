using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC5Demo.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            System.Diagnostics.Debug.WriteLine("RouteConfig Curren Thread :" + System.Threading.Thread.CurrentThread.ManagedThreadId);

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Department", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
