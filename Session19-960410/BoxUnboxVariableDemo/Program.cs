using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxUnboxVariableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            object p = new Person();
            object i = 10;
            object t = "John Doe";
            object d = DateTime.Now;

            //Person person = (Person)p;
            //Person person = p as Person;
            //Person person = (Person)i;
            Person person = i as Person;

            //Console.WriteLine(person.Name);
            //Console.WriteLine(d.Year);
            SampleFunction(p);
            SampleFunction(10);
            SampleFunction("John Doe");
            //Console.WriteLine(p.GetType());

            Console.ReadKey();
        }

        public static void SampleFunction(object obj)
        {

        }
    }
}
