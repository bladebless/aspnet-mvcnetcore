//Программы, игры и их исходные коды
//www.interestprograms.ru

using System.Web.Mvc;
using System.Web.Routing;

namespace ASPMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default", // название маршрута
                url: "{controller}/{action}/{id}", // структура маршрута
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional } // установки по умолчанию
            );
        }
    }
}
