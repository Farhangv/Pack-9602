using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByValByRefDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 10;
            Console.WriteLine(number);//10
            ChangeInt(ref number);
            Console.WriteLine(number);//20


            string text = "Hello ";
            Console.WriteLine(text);//Hello
            ChangeString(ref text);
            Console.WriteLine(text);//Hello From Function


            int[] array = new int[] { 10 };
            Console.WriteLine(array[0]);//10
            ChangeArray(ref array);
            Console.WriteLine(array[0]);//20

            Console.ReadKey();
        }
        static void ChangeArray(ref int[] z)
        {
            //z[0] = z[0] + 10;
            z = new int[] { 20 };
        }

        static void ChangeInt(ref int x)
        {
            x = x + 10;
        }

        static void ChangeString(ref string y)
        {
            y = y + "Change From Function";
        }

    }
}
