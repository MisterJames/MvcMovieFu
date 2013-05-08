using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieFu.Filters
{
    public class InjectUsernameAttribute : ActionFilterAttribute
    {
        // modified from original version at: http://weblogs.asp.net/rashid/archive/2009/04/01/asp-net-mvc-best-practices-part-1.aspx
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            const string Key = "Username";

            if (filterContext.ActionParameters.ContainsKey(Key))
            {
                if (filterContext.HttpContext.User.Identity.IsAuthenticated)
                    filterContext.ActionParameters[Key] = filterContext.HttpContext.User.Identity.Name;
                else
                    filterContext.ActionParameters[Key] = "";
            }
            else
                filterContext.ActionParameters.Add("Username", filterContext.HttpContext.User.Identity.Name);


            base.OnActionExecuting(filterContext);
        }
    }
}