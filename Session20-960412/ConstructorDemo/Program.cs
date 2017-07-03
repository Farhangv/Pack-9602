using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("John", "Doe", "1234567890");
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Family);
            Console.WriteLine(p.NationalCode);

            Console.ReadKey();
        }
    }
}
