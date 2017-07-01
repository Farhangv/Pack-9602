using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.Name = "John";
            std.NationalCode = "0123456789";
            std.BirthDate = DateTime.Parse("1980/10/10");
            //std.Age = 50;
            Console.WriteLine(std.Name);
            Console.WriteLine(std.NationalCode);
            Console.WriteLine(std.BirthDate);
            Console.WriteLine(std.Age);



            Console.ReadKey();
        }
    }
}
