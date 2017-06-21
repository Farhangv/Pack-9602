using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableAssignmentDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = a;
            Console.WriteLine(b);//10
            a = 20;
            Console.WriteLine(b);//10


            string c = "Sample";
            string d = c;
            Console.WriteLine(d);//Sample
            c = "Test";
            Console.WriteLine(d);//Test


            int[] e = new int[] { 10 };
            int[] f = e;
            Console.WriteLine(f[0]);//10
            e[0] = 20;
            Console.WriteLine(f[0]);//20

            Console.ReadKey();
        }
    }
}
