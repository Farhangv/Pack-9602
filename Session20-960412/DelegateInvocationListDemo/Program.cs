using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInvocationListDemo
{
    public delegate void Calculator(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator(sum);
            c += multiply;
            c += divide;

            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            c(num1, num2);

            Console.ReadKey();
        }

        private static void sum(int x, int y)
        {
            Console.WriteLine($"Sum : {x + y}");
        }
        private static void multiply(int x, int y)
        {
            Console.WriteLine($"Multiply: {x * y}");
        }

        private static void divide(int x, int y)
        {
            Console.WriteLine($"Divide: {x / y}");
        }
    }
}
