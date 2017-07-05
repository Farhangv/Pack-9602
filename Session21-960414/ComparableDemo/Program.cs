using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[] { "PHP", "Java", "Python", "C++", "C#" };
            var products = new Product[] {
                new Product() { Name = "Monitor", Code = "PK-1245" },
                new Product() { Name = "Laptop", Code = "LK-8563" },
                new Product() { Name = "Router", Code = "RK-7452" }
            };
            Array.Sort(names);
            Array.Sort(products);

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }

            Console.ReadKey();
        }
    }
}
