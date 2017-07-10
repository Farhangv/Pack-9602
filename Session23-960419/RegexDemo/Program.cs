using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace RegexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter Pattern:");
                var pattern = Console.ReadLine();
                if (pattern.ToLower() == "exit")
                    break;

                Regex re = new Regex(pattern);

                while (true)
                {
                    Console.Write("Enter Text:");
                    var text = Console.ReadLine();
                    if (text.ToLower() == "exit")
                        break;

                    if (re.IsMatch(text))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Not Valid");
                    }

                    Console.ForegroundColor = ConsoleColor.Gray;
                }

            }

        }
    }
}
