using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello\tC#");
            Console.WriteLine("Hello\nC#");
            //Console.WriteLine("Hello\mC#");
            Console.WriteLine("C:\\Windows");
            Console.WriteLine(@"C:\Windows");
            Console.WriteLine("My Name Is \"John Doe\"");
            Console.ReadKey();
        }
    }
}
