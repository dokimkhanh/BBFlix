using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BBFlix
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
               name: "Contact",
               url: "lien-he",
               defaults: new { controller = "Page", action = "Contact", id = UrlParameter.Optional },
               namespaces: new[] { "BBFlix.Controllers" }
           );

            routes.MapRoute(
               name: "FAQs",
               url: "faqs",
               defaults: new { controller = "Page", action = "FAQs", id = UrlParameter.Optional },
               namespaces: new[] { "BBFlix.Controllers" }
           );

            routes.MapRoute(
               name: "Upgrade",
               url: "nang-cap",
               defaults: new { controller = "Page", action = "AccoutUpgrade", id = UrlParameter.Optional },
               namespaces: new[] { "BBFlix.Controllers" }
           );

            routes.MapRoute(
                name: "About",
                url: "gioi-thieu",
                defaults: new { controller = "Page", action = "About", id = UrlParameter.Optional },
                namespaces: new[] { "BBFlix.Controllers" }
            );

            routes.MapRoute(
                name: "SingUp",
                url: "dang-ky",
                defaults: new { controller = "Signup", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "BBFlix.Controllers" }
            );

            routes.MapRoute(
                name: "Login",
                url: "dang-nhap",
                defaults: new { controller = "Login", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "BBFlix.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "BBFlix.Controllers" }
            );
        }
    }
}
