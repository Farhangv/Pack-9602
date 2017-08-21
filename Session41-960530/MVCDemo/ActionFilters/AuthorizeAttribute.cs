using MVCDemo.Models;
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
        public AuthorizeAttribute()
        {

        }
        private string _role;
        public AuthorizeAttribute(string role)
        {
            _role = role;
        }
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var user = SecurityService.GetCurrentUser();
            if (user == null)//Not Authenticated
            {
                //if(user is Student && _role == "Student")
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