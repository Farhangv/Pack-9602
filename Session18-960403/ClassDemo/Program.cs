using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student std = new Student();
            //std.id = 1;
            //std.name = "John";
            //std.family = "Doe";
            //std.birthDate = DateTime.Parse("1980/10/10");
            //std.phone = "091245678963";
            //std.nationalCode = "1234567890";

            Student std = new Student()
            {
                //name = "john",
                family = "doe",
                id = 1
            };
            std.SetName("john");
            //Student std2 = new Student()
            //{
            //    name = "sarah",
            //    family = "smith",
            //    id = 2
            //};

            //Console.WriteLine($"{std.name} {std.family}");
            std.WriteStudent();
            std.SetBirthDate(DateTime.Parse("2018/10/10"));
            //std.birthDate = DateTime.Parse("2018/10/10");
            Console.WriteLine(std.GetBirthDate());
            //std2.WriteStudent();

            Console.ReadKey();
        }
    }

    class Person
    {

    }
}
