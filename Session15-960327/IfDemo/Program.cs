using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Score:");
            int score = int.Parse(Console.ReadLine());
            if (score >= 90)
                Console.WriteLine("A+");
            else if (score >= 80)
            {
                Console.WriteLine("A");
            }
            else if (score >= 70)
                Console.WriteLine("B");
            else
            {
                Console.WriteLine("Failed");
            }

            Console.ReadKey();
        }
    }
}
