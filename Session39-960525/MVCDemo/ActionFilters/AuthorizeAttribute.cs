using MVCDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCDemo.ActionFilters
{
    public class AuthorizeAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(SecurityService.GetCurrentUser() == null)//Not Authenticated
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary
                    { 
                        { "controller" ,"Security" },
                        { "action" ,"Login" }
                    }
            );
            }
        }
    }
}