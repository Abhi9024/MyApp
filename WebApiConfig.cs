using AuthorService.Repo;
using AuthorService.Repo.DbConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;

namespace AuthorService
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.EnableCors();
            // Web API configuration and services
            var container = new UnityContainer();
            container.RegisterType<IMongoConfig, MongoConfig>();
            container.RegisterType<IAuthorRepository, AuthorRepository>();
            config.DependencyResolver = new UnityResolver(container);
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
