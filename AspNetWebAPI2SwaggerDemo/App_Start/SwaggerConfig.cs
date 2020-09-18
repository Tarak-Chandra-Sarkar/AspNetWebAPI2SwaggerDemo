using AspNetWebAPI2SwaggerDemo;
using Swashbuckle.Application;
using System.Web.Http;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace AspNetWebAPI2SwaggerDemo
{
    /// <summary>
    /// SwaggerConfig Class to Register
    /// </summary>
    public class SwaggerConfig
    {
        /// <summary>
        /// Register Method to EnableSwagger and EnableSwaggerUi
        /// </summary>
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration.EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "Books Swagger Demo Api");
                        c.IncludeXmlComments(string.Format(@"{0}\bin\WebAPISwaggerDemo.XML",
                                             System.AppDomain.CurrentDomain.BaseDirectory));                        
                    })
                    .EnableSwaggerUi();
        }
    }
}