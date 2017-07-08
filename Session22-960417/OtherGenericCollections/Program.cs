using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> messages = new Stack<string>();
            messages.Push("First Message");
            messages.Push("Second Message");
            messages.Push("Third Message");

            Console.WriteLine(messages.Pop());
            Console.WriteLine(messages.Pop());
            Console.WriteLine(messages.Pop());

            Queue<string> q = new Queue<string>();
            q.Enqueue("First Message");
            q.Enqueue("Second Message");
            q.Enqueue("Third Message");

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Dequeue());

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("C#", "Microsoft OO Language");
            dictionary.Add("Java", "Oracle's OO Language");

            Console.WriteLine(dictionary["C#"]);
            Console.WriteLine(dictionary["Java"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }


            Console.ReadKey();
        }
    }
}
