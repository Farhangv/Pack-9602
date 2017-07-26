using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return Content("Welcome To MVC");
            //return new ContentResult() {
            //    ContentType = "text/plain",
            //    ContentEncoding = Encoding.UTF8,
            //    Content = "Welcome To MVC"
            //};
            return Content("Welcome to MVC");
        }
        public ActionResult About()
        {
            return View("~/Views/AboutCompany/Description.cshtml");
        }
    }
}