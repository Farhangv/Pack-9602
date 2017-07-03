using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassFunctionAsParameterDemo
{
    delegate bool NumberFilter(int num);

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //WriteFilteredNumbers(numbers, EvenFilter);
            //WriteFilteredNumbers(numbers, (x) => 
            //    {
            //        return x % 2 == 0;
            //    } 
            //);
            WriteFilteredNumbers(numbers, x => x % 2 == 0);

            Console.ReadKey();
        }

        static void WriteFilteredNumbers(int[] numbers, NumberFilter filter)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (filter(numbers[i]))
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }


        static bool OddFilter(int x)
        {
            return x % 2 != 0;
        }

        static bool EvenFilter(int x)
        {
            return x % 2 == 0;
        }
    }
}
