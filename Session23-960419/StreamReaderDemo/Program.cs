using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReaderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("Phonebook.txt"))
            {
                //while (sr.Peek() != -1)
                //{
                //    //Console.Write((char)sr.Read());
                //    Console.WriteLine(sr.ReadLine());
                //}
                Console.WriteLine(sr.ReadToEnd());
            }

            Console.ReadKey();
        }
    }
}
