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
            return new List<Student>() {
                new Student() { Id = 1, Name = "جان", Family = "دو" },
                new Student() { Id = 2, Name = "علی", Family = "علیان" },
                new Student() { Id = 3, Name = "سیاوش", Family = "نوری" },
                new Student() { Id = 4, Name = "مهران", Family = "مهرانی" }
            };
        }

        public static bool CreateStudent(string name, string family)
        {
            return true;
        }

        public static bool CreateStudent(Student student)
        {
            return true;
        }

    }
}