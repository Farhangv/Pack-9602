using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            //name = "John";
            Console.WriteLine("Please Enter Your Name");
            name = Console.ReadLine();
            char grade = 'A';
            Console.WriteLine(name);
            Console.WriteLine(grade);
            Console.ReadKey();
        }
    }
}
