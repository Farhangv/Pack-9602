using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInitializerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //var names = new string[5];
            //names[0] = "C#";

            //Array Initializer
            var names = new string[] { "C#","Java","PHP", "Python","Perl" };
            

            Console.WriteLine($"Array Length: {names.Length}");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadKey();

        }
    }
}
