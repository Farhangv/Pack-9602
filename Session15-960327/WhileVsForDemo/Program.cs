using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileVsForDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            //{
            //    int i = 0;
            //    Console.WriteLine(i++);
            //}

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
