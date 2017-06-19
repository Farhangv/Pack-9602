using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[100];
            Random r = new Random();
            for (int i = 0; i < numbers.Length; i++)//پر کردن آرایه
            {
                numbers[i] = r.Next(1000, 1150);
            }

            Array.Sort(numbers);

            foreach (var number in numbers)//نمایش اعضای آٰایه
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
