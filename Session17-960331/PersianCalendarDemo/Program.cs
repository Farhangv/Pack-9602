using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PersianCalendarDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                PersianCalendar pc = new PersianCalendar();
                Console.WriteLine("Welcome To My Date Converter");
                Console.Beep(5000, 700);
                Console.Beep(10000, 400);
                Console.Beep(2000, 1000);
                Console.Clear();
                Console.WriteLine("1.Persian To Gregorian\n2.Gregorian To Persian");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Persian Date:(yyyy/MM/dd)");
                            var persianDate = Console.ReadLine().Split('/');
                            var year = int.Parse(persianDate[0]);
                            var month = int.Parse(persianDate[1]);
                            var day = int.Parse(persianDate[2]);
                            var gregorianDate = pc.ToDateTime(year, month, day, 0, 0, 0, 0);
                            Console.WriteLine(gregorianDate.ToShortDateString());
                        }
                        break;


                    case 2:
                        {
                            Console.WriteLine("Enter Gregorian Date:(yyyy/MM/dd)");
                            var gregorianDate = DateTime.Parse(Console.ReadLine());
                            var year = pc.GetYear(gregorianDate);
                            var month = pc.GetMonth(gregorianDate);
                            var day = pc.GetDayOfMonth(gregorianDate);
                            Console.WriteLine($"{year}/{month:00}/{day:00}");
                        }
                        break;
                }

                Console.ReadKey();
            }
        }
    }
}
