using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionDemo
{
    class Program
    {
        static void Main()
        {
            WriteWelcome();
            Console.WriteLine("Name:");
            var name = Console.ReadLine();
            Console.WriteLine("Family:");
            var family = Console.ReadLine();
            WriteHello(name, family);
            Console.WriteLine("Write Your Persian BirthDate(yyyy/mm/dd):");
            var persianBirthDate = Console.ReadLine().Split('/');
            //Console.WriteLine(ConvertToGregorianDate(persianBirthDate).ToShortDateString());
            var persianYear = int.Parse(persianBirthDate[0]);
            var persianMonth = int.Parse(persianBirthDate[1]);
            var persianDay = int.Parse(persianBirthDate[2]);
            Console.WriteLine(ConvertToGregorianDate(persianYear,persianMonth,persianDay).ToShortDateString());
            
            Console.ReadKey();
        }

        static void WriteWelcome()
        {
            Console.WriteLine("Welcome To My Application!");
            Console.WriteLine("This Is Functions Demonstration");
        }
        static void WriteHello(string name, string family)
        {
            Console.WriteLine($"Hello {name} {family}");
        }

        static DateTime ConvertToGregorianDate(int year, int month, int day)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.ToDateTime(year, month, day, 0, 0, 0, 0);
        }
        static DateTime ConvertToGregorianDate(string[] dateParts)
        {
            PersianCalendar pc = new PersianCalendar();
            
            var result = pc.ToDateTime(
                int.Parse(dateParts[0]),
                int.Parse(dateParts[1]),
                int.Parse(dateParts[2]),
                0,0,0,0
                );

            return result;
        }

    }
}
