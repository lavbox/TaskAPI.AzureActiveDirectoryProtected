using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;

namespace SecureTaskAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();


            //config.Routes.MapHttpRoute(
            //   name: "user_get",
            //   routeTemplate: "api/user/{email}",
            //   defaults: new {controller = "User", action = "GetUserByEmail"}
            //   );

            //config.Routes.MapHttpRoute(
            //  name: "user_post",
            //  routeTemplate: "api/user",
            //  defaults: new { controller = "User", action = "CreateNewUser" }
            //  );
            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{value}",
            //     defaults: new { value = RouteParameter.Optional }
            //);

            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.All;
        }
    }
}
