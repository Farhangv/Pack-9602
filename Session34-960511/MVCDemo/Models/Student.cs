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
        //[Key]
        public int Id { get; set; }
        [Required, Column("FirstName"), StringLength(50)]
        //[Column("FirstName")]
        public string Name { get; set; }
        [Required,Column("LastName"), StringLength(50)]
        public string Family { get; set; }
        [NotMapped]
        public int Age {
            get {
                return DateTime.Now.Year - BirthDate.Year;
            }
        }
        //public DateTime? BirthDate { get; set; } ---> Nullable BirthDate
        public DateTime BirthDate { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}