using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            string family = "Doe";
            int age = 40;
            string phone = "02112345678";

            Console.WriteLine("Hello " + name + " " + family + "You Are " + age + "Years Old Your Phone Number Is " + phone);
            Console.WriteLine("Hello {0} {1} You Are {2} Years Old And Your Phone Number Is {3}", name,family,age,phone);

            //string result = string.Format("Hello {0} {1} You Are {2} Years Old And Your Phone Number Is {3}", name, family, age, phone);
            //Console.WriteLine(result);
            //Console.WriteLine("سلام");

            //Console.WriteLine("Hello {0} {1} You Are {2} Years Old And Your Phone Number Is {3}");


            string result = $"Hello {name} {family} You Are {age} Years Old And Your Phone Is {phone}";
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
