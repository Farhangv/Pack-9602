using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[10];
            for (int i = 0; i < names.Length; i++)
            {
                Console.Clear();
                for (int j = 0; j < names.Length; j++)
                {
                    if(names[j] != null)
                        Console.WriteLine(names[j]);
                }
                Console.WriteLine("------------------");
                Console.WriteLine("Enter Name :");
                var name = Console.ReadLine();
                names[i] = name;
            }
        }
    }
}
