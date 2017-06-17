using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Sum\n2.Divide\n3.Multiply");
            var selectedItem = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (selectedItem)
            {
                case 1:
                    Console.WriteLine("Enter First Number:");
                    var first = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second Number:");
                    var second = int.Parse(Console.ReadLine());
                    Console.WriteLine(first + second);
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
