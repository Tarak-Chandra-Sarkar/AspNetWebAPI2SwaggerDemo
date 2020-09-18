using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace AspNetWebAPI2SwaggerDemo
{
    /// <summary>
    /// WebApiConfig CLass to Register Map Route Patterns
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Register to configure map http attribute and default route
        /// </summary>
        /// <param name="config"></param>
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
