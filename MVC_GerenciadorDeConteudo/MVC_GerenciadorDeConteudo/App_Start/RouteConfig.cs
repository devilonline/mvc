using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_GerenciadorDeConteudo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "sobre",
                "sobre",
                new { controller = "Home", action = "about" });

            routes.MapRoute(
              "paginas",
              "paginas",
              new { controller = "Paginas", action = "Index" });

            routes.MapRoute(
           "paginas_novo",
           "paginas/novo",
           new { controler = "Paginas", action = "Novo" }
           );

            routes.MapRoute(
                "contato",
                "contato",
                new { controller = "Home", action = "contact" });



       




            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
