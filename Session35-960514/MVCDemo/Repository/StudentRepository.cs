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
                //Query
                //var students = ctx.Students;//SELECT * FROM Students.Student
                //var students = from s in ctx.Students //SELECT * FROM Students.Student
                //               select s;
                //var students = from s in ctx.Students
                //                //where s.BirthDate < DateTime.Parse("1980/10/10")
                //                //where s.Name.StartsWith("ا")
                //                //where s.Contacts.Count > 2
                //                //where s.BirthDate.Year == 1980
                //                //where s.Family.StartsWith("ن")
                //                //orderby s.Name
                //                orderby s.Name descending
                //               select s;

                var students = ctx.Students.OrderByDescending(s => s.Name);

                //Execution
                return students.ToList();
            }//ctx.Dispose();
        }

        public static bool CreateStudent(string name, string family)
        {
            return true;
        }

        public static bool CreateStudent(Student student)
        {
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
                //var contact = (from c in ctx.Contacts
                //              where c.Value == contactValue
                //              select c).FirstOrDefault();
                //return contact.Student.Courses.ToList();

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