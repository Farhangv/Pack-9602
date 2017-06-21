using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DateTimeToStringDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //for (;;)
            //{
            //    Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));

            //}
            while (true)
            {
                Console.Clear();
                Console.WriteLine(DateTime.Now.ToLongDateString());
                Console.WriteLine(DateTime.Now.ToShortTimeString());
                Console.WriteLine(DateTime.Now.ToString("yyyy|MM|dd"));
                Console.WriteLine(DateTime.Now.ToString("HH-mm-ss"));
                Thread.Sleep(1000);
            }

        }
    }
}
