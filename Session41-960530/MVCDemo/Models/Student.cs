using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [Table("Student", Schema = "Students")]
    public class Student
    {
        [ForeignKey("User")]
        public int Id { get; set; }
        [Required(ErrorMessage = "ورود نام اجباریست"), Column("FirstName"), StringLength(50), Display(Name = "نام")]
        public string Name { get; set; }
        [Required(ErrorMessage = "ورود نام خانوادگی اجباریست"), Column("LastName"), StringLength(50), Display(Name = "فامیل")]
        public string Family { get; set; }
        [NotMapped]
        public int Age {
            get {
                return DateTime.Now.Year - BirthDate.Year;
            }
        }
        [Display(Name = "تاریخ تولد")]
        public DateTime BirthDate { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        [Display(Name = "ایمیل"),
            RegularExpression(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", ErrorMessage = "ایمیل شما احتمالا نا معتبر است")]
        public string Email { get; set; }
        [Display(Name = "موبایل"), StringLength(11, MinimumLength = 11, ErrorMessage = "شماره موبایل باید ۱۱ رقمی باشد"),
            RegularExpression(@"^09\d{9}$", ErrorMessage = "شماره موبایل شما معتبر نیست")]
        public string Phone { get; set; }
        [Display(Name = "شماره شناسنامه"), Required(ErrorMessage = "ورود شماره شناسنامه اجباریست")]
        public int BirthCertificateNumber { get; set; }
        [Display(Name = "توضیحات")]
        public string Description { get; set; }

        public byte[] Photo { get; set; }
        [MaxLength(5)]
        public string PhotoExtension { get; set; }
        [MaxLength(100)]
        public string PhotoOriginalFileName { get; set; }
        [MaxLength(30)]
        public string PhotoContentType { get; set; }
        /// <summary>
        /// Size in KB
        /// </summary>
        public int? PhotoSize { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}