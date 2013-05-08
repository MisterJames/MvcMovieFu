using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using BootstrapMvcSample.Controllers;
using NavigationRoutes;
using MovieFu.Controllers;

namespace BootstrapMvcSample
{
    public class ExampleLayoutsRouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapNavigationRoute<HomeController>("Home", c => c.Index());

            routes.MapNavigationRoute<PersonController>("People", c => c.Null())
                .AddChildRoute<PersonController>("View All", c => c.Index())
                .AddChildRoute<PersonController>("Create New", c => c.Create());

            routes.MapNavigationRoute<MoviesController>("Movies", c => c.Null())
                .AddChildRoute<MoviesController>("View All", c => c.Index())
                .AddChildRoute<MoviesController>("Create New", c => c.Create());

        }
    }
}
