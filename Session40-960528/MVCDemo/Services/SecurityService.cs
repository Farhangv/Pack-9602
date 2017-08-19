using MVCDemo.Models;
using MVCDemo.Repository;
using MVCDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Services
{
    public class SecurityService
    {
        public static bool Authenticate(LoginViewModel viewModel)
        {
            var user = UserRepository
                .GetUserByUsernameAndPassword(viewModel.Username, viewModel.Password);

            if(user != null)//Authenticated
            {
                HttpContext.Current.Session["User"] = user;

                if (viewModel.RememberMe)
                {
                    HttpCookie cookie = new HttpCookie("User");
                    cookie.Value = user.Id.ToString();
                    cookie.Expires = DateTime.Now.AddDays(14);
                    HttpContext.Current.Response.Cookies.Add(cookie);
                }
                return true;
            }
            else// Invalid User
            {
                return false;
            }
        }

        public static User GetCurrentUser()
        {
            var cookie = HttpContext.Current.Request.Cookies["User"];
            if (cookie != null)
            {
                var userId = int.Parse(cookie.Value);
                using (var ctx = new StudentPortalDb())
                {
                    var user = ctx.Users.Find(userId);
                    HttpContext.Current.Session["User"] = user;
                }
            }
            return HttpContext.Current.Session["User"] as User;
        }
        public static void Logout()
        {
            var cookie = HttpContext.Current.Request.Cookies["User"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddDays(-1);
                HttpContext.Current.Response.Cookies.Add(cookie);
            }
            HttpContext.Current.Session["User"] = null;
        }
    }
}