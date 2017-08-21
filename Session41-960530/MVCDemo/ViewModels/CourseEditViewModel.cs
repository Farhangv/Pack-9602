using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.ViewModels
{
    public class CourseEditViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? Duration { get; set; }
        public List<int> StudentIds { get; set; }
    }
}