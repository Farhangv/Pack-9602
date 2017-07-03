using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCreatingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.InvalidAgeEntered += new InvalidAgeEneteredHandler(InvalidHandler);
            Console.WriteLine("Age?");
            p.Age = int.Parse(Console.ReadLine());

            Console.ReadKey();

        }

        static void InvalidHandler()
        {
            Console.WriteLine("Invalid Age!");
        }
    }
}
