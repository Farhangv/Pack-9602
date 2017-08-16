using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.ViewModels
{
    public class StudentCreateViewModel
    {
        [Required(ErrorMessage = "ورود نام اجباریست"), StringLength(50), Display(Name = "نام")]
        public string Name { get; set; }
        [Required(ErrorMessage = "ورود نام خانوادگی اجباریست"), StringLength(50), Display(Name = "فامیل")]
        public string Family { get; set; }
        [Display(Name = "ایمیل"), RegularExpression(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", ErrorMessage = "ایمیل شما احتمالا نا معتبر است")]
        public string Email { get; set; }
        [Display(Name = "موبایل"), StringLength(11, MinimumLength = 11, ErrorMessage = "شماره موبایل باید ۱۱ رقمی باشد"),
            RegularExpression(@"^09\d{9}$", ErrorMessage = "شماره موبایل شما معتبر نیست")]
        public string Phone { get; set; }
        [Display(Name = "شماره شناسنامه"), Required(ErrorMessage = "ورود شماره شناسنامه اجباریست")]
        public int BirthCertificateNumber { get; set; }
        [Display(Name = "توضیحات")]
        public string Description { get; set; }
        [Required(ErrorMessage = "ورود نام کاربری الزامیست"), Display(Name = "نام کاربری")]
        public string Username { get; set; }
        [Required(ErrorMessage = "ورود کلمه عبور الزامیست"), Display(Name = "کلمه عبور")]
        public string Password { get; set; }
        [Required(ErrorMessage = "ورود تکرار کلمه عبور الزامیست"), 
            Display(Name = "تکرار کلمه عبور"), 
            Compare(nameof(Password), ErrorMessage = "کلمه عبور با تکرار آن یکسان نیست")]
        public string ConfirmPassword { get; set; }
    }
}