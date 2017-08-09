using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [Table("Contact",Schema = "Students")]
    public class Contact
    {
        public int Id { get; set; }
        [Required, MaxLength(10)]
        public string Type { get; set; }
        [Index(IsUnique = true), MaxLength(100)]
        public string Value { get; set; }
        public virtual Student Student { get; set; }
        public int StudentId { get; set; }
    }
}