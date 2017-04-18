using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OwinAuthentication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //posicao = UrlParameter.Optional
            routes.MapRoute(
            name: "Testa Error",
            url: " ErrorPage/Vizualizar/{posicao}",
            defaults: new { controller = "ErrorPage", action = "Vizualizar" });

            routes.MapRoute(
            name: "Default",
            url: "{controller}/{action}/{id}",
            defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //Caso use Areas defina o namespace
            ,namespaces: new[] { "OwinAuthentication.Controllers" }
                
            );
        }
    }
}
