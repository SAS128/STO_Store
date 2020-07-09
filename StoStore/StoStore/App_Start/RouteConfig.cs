using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace StoStore
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapPageRoute(null, "", "~/Pages/WebSTO.aspx");
            routes.MapPageRoute(null, "list", "~/Pages/WebSTO.aspx");
            routes.MapPageRoute(null, "list/{page}", "~/Pages/WebSTO.aspx");
            routes.MapPageRoute(null, "list/{category}/{page}", "~/Pages/WebSTO.aspx");

        }
    }
}

