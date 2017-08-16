using MVCDemo.Library;
using MVCDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PanelController : Controller
    {
        [MVCDemo.ActionFilters.Authorize]
        public ActionResult Index()
        {
            return Content("مجاز");
        }
        public ActionResult CourseList()
        {
            if (SecurityService.GetCurrentUser() != null)
            {
                return Content("مجاز");
            }
            else
            {
                return Content("غیر مجاز");
            }
        }
        public ActionResult ScoresList()
        {
            if (SecurityService.GetCurrentUser() != null)
            {
                return Content("مجاز");
            }
            else
            {
                return Content("غیر مجاز");
            }
        }
    }
}