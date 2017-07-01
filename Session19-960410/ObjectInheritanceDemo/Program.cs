using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.PersonId = 1;
            p.Name = "John";
            p.Family = "Doe";
            Person p2 = new Person();
            p2.PersonId = 1;
            p2.Name = "John";
            p2.Family = "Doe";

            Console.WriteLine(p);

            //Console.WriteLine(p.GetType());
            //Console.WriteLine(p.GetHashCode());
            //Console.WriteLine(p.ToString());
            //Console.WriteLine(p.Equals(p));
            //Console.WriteLine(p.Equals(p2));
            Console.ReadKey();
        }

        //public void WriteLine(object obj)
        //{
        //    Console.WriteLine(obj.ToString());
        //}
    }
}
