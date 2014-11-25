using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Test_AJAX
{
    /*
     * NikB test ptoject 
     * AJAX chaice product(s)
     * from:
     * http://www.asp.net/web-api/overview/getting-started-with-aspnet-web-api/tutorial-your-first-web-api
     * to future AJAX CRUD (create, read, update, delete) product:
     * http://www.asp.net/web-api/overview/older-versions/creating-a-web-api-that-supports-crud-operations
     */
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
        }
    }
}
