using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main()
        {
            //string name = "John";
            //String family = new String(new char[] { 'D', 'o', 'e' });
            string[] names = new string[3];
            //names[0] = "Siavash Noori";
            //names[1] = "Mohammad Akbari";
            //names[2] = "Mahdi IranDoost";
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = Console.ReadLine();
            }

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            Console.ReadKey();
        }
    }
}
