using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Repository
{
    public class StudentRepository
    {
        public static IEnumerable<Student> GetAllStudents()
        {
            using (StudentPortalDb ctx = new StudentPortalDb())//;
            {
                var students = ctx.Students.OrderByDescending(s => s.Name);
                return students.ToList();
            }
        }

        public static bool CreateStudent(string name, string family)
        {
            return true;
        }

        public static bool CreateStudent(Student student)
        {
            using (var ctx = new StudentPortalDb())
            {
                //var user = ctx.Users.Where(u => u.Username == "david").FirstOrDefault();
                //student.User = user;
                Random r = new Random();
                student.User = new User() {
                    Username = r.Next(1000000, 2000000).ToString(),
                    Password = r.Next(1000000, 2000000).ToString()
                };
                student.BirthDate = DateTime.Now;
                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
            return true;
        }

        public static IEnumerable<Contact> GetStudentContacts(int studentId)
        {
            using (var ctx = new StudentPortalDb())
            {
                var student =  from s in ctx.Students
                               where s.Id == studentId
                               select s;

                return student.First().Contacts.ToList() ;
            }

        }

        public static IEnumerable<Course> GetCoursesByContact(string contactValue)
        {
            using (StudentPortalDb ctx = new StudentPortalDb())
            {
                return ctx.Contacts
                    .Where(c => c.Value == contactValue)
                    .FirstOrDefault()
                    .Student
                    .Courses
                    .ToList();
            }
        }

    }
}