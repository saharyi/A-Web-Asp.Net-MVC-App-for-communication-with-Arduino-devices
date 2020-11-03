using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace test3
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "home2",
                routeTemplate: "api/home2/{id}",
                defaults: new { controller = "home2", id = RouteParameter.Optional },
                constraints: new { id = "/d+" }
            );
        }
    }
}
