using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutDemo
{
    class Program
    {
        static void Main()
        {
            var name = Console.ReadLine();
            double average;
            int rank;
            var isPassed = GetStudentStatus(name, out average, out rank);
            Console.WriteLine(isPassed);
            Console.WriteLine(average);
            Console.WriteLine(rank);
            Console.ReadKey();
        }

        static bool GetStudentStatus(string studentName, out double average, out int rank)
        {
            switch (studentName)
            {
                case "john":
                    average = 15;
                    rank = 100;
                    return true;
                case "david":
                    average = 11;
                    rank = 500;
                    return false;

                default:
                    average = 0;
                    rank = 0;
                    return false;
            }
        }
    }
}
