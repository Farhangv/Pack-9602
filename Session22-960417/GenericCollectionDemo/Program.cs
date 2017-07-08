using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("C#");
            names.Add("PHP");

            List<Product> products = new List<Product>();
            products.Add(new Product() { Code = "PR-8569", Name = "Laptop Dell" });
            //products.Add("Java");
            //products.Remove()

            foreach (Product product in products)
            {
                Console.WriteLine(product.Name);
            }

            Console.ReadKey();
        }
    }
}
