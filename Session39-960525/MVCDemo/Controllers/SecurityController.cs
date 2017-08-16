using MVCDemo.Services;
using MVCDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class SecurityController : Controller
    {

        public ActionResult Login()
        {
            if (SecurityService.GetCurrentUser() == null)
                return View();
            else
                return RedirectToAction("Index", "Home");
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Login(LoginViewModel viewModel)
        {
            var authenticate = SecurityService.Authenticate(viewModel);
            if(authenticate)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "نام کاربری یا کلمه عبور اشتباه است");
                return View();
            }
        }

        public ActionResult Logout()
        {
            SecurityService.Logout();
            return RedirectToAction("Index", "Home");
        }
    }
}