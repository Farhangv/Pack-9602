using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(',');

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            int min = int.Parse(numbers[0]);

            for (int i = 1; i < numbers.Length; i++)
            {
                if (int.Parse(numbers[i]) < min)
                    min = int.Parse(numbers[i]);
            }

            Console.WriteLine(min);
            //Console.WriteLine(numbers.Select(n => int.Parse(n)).Min());

            Console.ReadKey();
        }
    }
}
