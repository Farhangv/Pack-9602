using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Samand s = new Samand();
            Samand.Company = "Iran Khodro";


            //Program p = new Program();
            //p.WriteText();

            Program.WriteText();

            //Math m = new Math();
        }

        private static void WriteText()
        {
            Console.WriteLine("Sample Text");
        }
    }
}
