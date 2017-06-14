using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("john".ToUpper());
            Console.WriteLine("DoE".ToLower());
            Console.WriteLine("John Doe".Contains("Doe"));
            Console.WriteLine("John Doe".IndexOf('o'));
            Console.WriteLine("John Doe".LastIndexOf('o'));
            Console.WriteLine("John Doe".Length);
            Console.WriteLine("John Doe".Replace("Doe", "Williams"));
            Console.WriteLine("John Doe".Substring(2, 3));
            Console.WriteLine("John Doe".StartsWith("J"));
            Console.WriteLine("John Doe".EndsWith("e"));
            Console.WriteLine("Hello"+ "           John Doe       " + "How Are You?");
            Console.WriteLine("Hello" + "           John Doe       ".Trim() + "How Are You?");
            Console.WriteLine("Hello" + "           John Doe       ".TrimEnd() + "How Are You?");
            Console.WriteLine("Hello" + "           John Doe       ".TrimStart() + "How Are You?");

            Console.ReadKey();
        }
    }
}
