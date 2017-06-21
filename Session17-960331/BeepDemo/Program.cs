using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeepDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            while(true)
            {
                Console.Beep(r.Next(2000, 20000), r.Next(20, 500));
            }
        }
    }
}
