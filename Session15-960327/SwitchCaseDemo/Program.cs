using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Programming Language Name:");
            string name = Console.ReadLine().ToLower();
            switch (name)
            {
                case "c#":
                case "vb":
                    Console.WriteLine("Microsoft's OO Programming Language");
                    break;
                case "java":
                    Console.WriteLine("Oracle's OO Programming Language");
                    break;
                case "php":
                    Console.WriteLine("Open Source Web Development Language");
                    break;

                default:
                    Console.WriteLine("I Don't Know!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
