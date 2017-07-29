using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicDemo
{
    class Program
    {
        

        static void Main(string[] args)
        {
            dynamic person = new { Name = "" };
            person.Name = "John";
            person.Family = "Doe";


            Console.WriteLine(person.Name);
            Console.WriteLine(person.Family);

            Console.ReadKey();
        }
    }
}
