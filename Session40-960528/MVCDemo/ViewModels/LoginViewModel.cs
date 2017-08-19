using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.ViewModels
{
    public class LoginViewModel
    {
        [Required, Display(Name = "نام کاربری")]
        public string Username { get; set; }
        [Required, Display(Name = "کلمه عبور")]
        public string Password { get; set; }
        [Display(Name = "مرا به خاطر بسپار")]
        public bool RememberMe { get; set; }
    }
}