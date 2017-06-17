using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter Number:");
                //int number = int.Parse(Console.ReadLine());
                string input = Console.ReadLine().ToLower();
                int number = 0;
                if (input == "exit")
                    break;
                else
                    number = int.Parse(input);

                int factorial = 1;
                while (number > 1)
                {
                    //factorial = number * factorial;
                    //factorial *= number;
                    //number = number - 1;
                    //number -= 1;
                    //number--;

                    //factorial *= --number;
                    factorial *= number--;
                }
                Console.WriteLine(factorial);

            }

            //Console.ReadKey();
        }
    }
}
