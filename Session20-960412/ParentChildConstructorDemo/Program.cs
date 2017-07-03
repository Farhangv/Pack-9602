using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentChildConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("John","Doe");
            Employee e = new Employee("Sarah", "Smith");

            Console.ReadKey();
        }
    }
}
