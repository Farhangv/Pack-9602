using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.ViewModels
{
    public class SubmitAssignmentViewModel
    {
        [Display(Name = "درس")]
        public int CourseId { get; set; }
        [Display(Name = "فایل")]
        public HttpPostedFileBase PostedFile { get; set; }
    }
}