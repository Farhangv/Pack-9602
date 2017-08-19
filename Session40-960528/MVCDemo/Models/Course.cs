using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [Table("Course", Schema = "Edu")]
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? Duration { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}