using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number - i; j++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
