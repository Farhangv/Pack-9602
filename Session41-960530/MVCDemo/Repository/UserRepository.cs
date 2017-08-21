using MVCDemo.Library;
using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Repository
{
    public class UserRepository
    {
        public static User GetUserByUsernameAndPassword(string username, string password)
        {
            using (StudentPortalDb ctx = new StudentPortalDb())
            {
                var passwordHash = SecurityHelper.ToMD5(password);
                return ctx.Users.Where(u => u.Username == username && u.PasswordHash == passwordHash)
                    .FirstOrDefault();
            }
        }
    }
}