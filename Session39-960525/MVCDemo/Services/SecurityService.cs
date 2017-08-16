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
                return true;
            }
            else// Invalid User
            {
                return false;
            }
        }

        public static User GetCurrentUser()
        {
            return HttpContext.Current.Session["User"] as User;
        }
        public static void Logout()
        {
            HttpContext.Current.Session["User"] = null;
        }
    }
}