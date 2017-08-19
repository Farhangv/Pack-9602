using MVCDemo.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [Table("User", Schema = "Security")]
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        [NotMapped]
        public string Password { get
            {
                return PasswordHash;
            }
                set {
                PasswordHash = SecurityHelper.ToMD5(value);
            }
        }
        public string PasswordHash { get; set; }
        public virtual Student Student { get; set; }
    }
}