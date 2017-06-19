using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            Console.WriteLine(now.AddDays(10));
            Console.WriteLine(now.AddDays(-10));
            Console.WriteLine(now.AddYears(10));
            Console.WriteLine(now.AddMonths(10));
            Console.WriteLine(now.AddHours(10));
            Console.WriteLine(now.AddMinutes(10));
            Console.WriteLine(now.AddSeconds(10));
            Console.WriteLine(now.AddMilliseconds(10));

            Console.WriteLine(now.Year);
            Console.WriteLine(now.Month);
            Console.WriteLine(now.Day);
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);
            Console.WriteLine(now.Second);
            Console.WriteLine(now.Millisecond);


            DateTime birhDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Your Age Is {now.Year - birhDate.Year}");


            Console.ReadKey();
        }
    }
}
