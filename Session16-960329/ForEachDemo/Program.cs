using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }

            //foreach (string name in names)
            //{
            //    name = Console.ReadLine();
            //}
            Console.WriteLine("-----------------------");
            Array.Sort(names);
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            Console.WriteLine(string.Join(",", names));

            Console.ReadKey();
        }
    }
}
