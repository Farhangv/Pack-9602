using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam exam = new Exam();
            exam.Questions = new Question[] {
                new Question() { Number = 1, Text = "Count Three OO Programming Langueges" },
                new Question() { Number = 2, Text = "Describe What is Polymorphism in OOP?" },
                new Question() { Number = 3, Text = "Describe Usage of properties in Class?" },
                new Question() { Number = 4, Text = "What's Your Name?" }
            };

            foreach (var q in exam)
            {
                Console.WriteLine(q);
            }

            Console.ReadKey();
        }
    }
}
