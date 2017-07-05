using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ICostable[] costs = new ICostable[]
                {
                    new Employee() { Cost = 10000, Name = "John", Family = "Doe" },
                    new Product() { Cost = 1000, CompanyName = "Microsoft" },
                    new Service() { Cost = 2000, CompanyName = "Oracle" },
                    //new Animal()
                };

            var sum = 0;
            foreach (ICostable item in costs)
            {
                Console.Write($"{item.Cost} ");
                if (item is IProvidedByOtherCompany)
                {
                    Console.Write(((IProvidedByOtherCompany)item).CompanyName);
                }

                sum += item.Cost;

                Console.WriteLine();
            }
            Console.WriteLine("---------------");
            Console.WriteLine(sum);

            Console.ReadKey();
        }
    }
}
