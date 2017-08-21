using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Assignment
    {
        public int Id { get; set; }
        public virtual Course Course { get; set; }
        public int CourseId { get; set; }
        public virtual Student Student { get; set; }
        public int StudentId { get; set; }

        public string FileName { get; set; }
    }
}