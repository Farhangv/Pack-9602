using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericDemo
{
    class Program
    {
        static void Main(string[] args)
        { 
            ArrayList al = new ArrayList();
            al.Add(100);
            al.Add(DateTime.Now);
            al.Add("John");
            al.Add(new Person() { Id = 1, Name = "Sarah", Family = "Smith" });
            al.AddRange(new int[] { 10, 20, 30, 40, 50, 10 });

            al.Remove("John");
            al.Remove(new Person() { Id = 1, Name = "Sarah", Family = "Smith" });
            al.RemoveAt(2);

            foreach (var item in al)
            {
                if (item is DateTime)
                    Console.WriteLine(((DateTime)item).AddDays(10));
                else if(item is Person)
                    Console.WriteLine($"{((Person)item).Name} {((Person)item).Family}");
                else
                    Console.WriteLine(item);
            }

            Console.WriteLine(al.Contains("John"));
            Console.WriteLine(al.IndexOf(10));
            Console.WriteLine(al.LastIndexOf(10));
            Console.WriteLine(al.Count);
            Console.WriteLine(al[al.Count - 1]);
            Console.ReadKey();

        }
    }
}
