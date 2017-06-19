using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace UniqueRandomNumbersDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var numbers = new int[300000];
            Random r = new Random();
            for (int i = 0; i < numbers.Length;)
            {
                var randomNumber = r.Next(1000000, 1500000);//عدد تصادفی که در این مرحله تولید شده است
                bool isUnique = true;
                for (int j = 0; j < i; j++)
                {
                    if (randomNumber == numbers[j])//اگر حاصل این شرط صادق باشد یعنی عدد تصادفی جدید تولید شده قبلا در آرایه وجود داشته
                    {
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    numbers[i++] = randomNumber;
                    //i++;
                }
                //else
                //{
                //    i--;
                //}
            }
            sw.Stop();


            Array.Sort(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("-------------------");
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
    }
}
