using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Filters;

namespace ClinIOS
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
           // config.MapHttpAttributeRoutes();

            config.Filters.Add(new AuthorizeAttribute());   // need to remove after login set

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
       
    }
}
