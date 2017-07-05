using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person();
            Person[] people = new Person[]
                {
                    new Teacher() { Name = "John", Family = "Doe", Rate = 2000, TeachingHours = 30 },
                    new Student() { Name = "Sarah" , Family = "Smith", CourseCount = 3, CoursePrice = 10000 }
                };

            double sum = 0;
            //foreach (Person p in people)
            //{
            //    Console.WriteLine($"{p.Name} {p.Family} : {p.GetBalance()}");
            //    sum += p.GetBalance();
            //}

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"{people[i].Name} {people[i].Family} : {people[i].GetBalance()}");
                sum += people[i].GetBalance();
            }

            Console.WriteLine("-----------------");
            Console.WriteLine(sum);

            Console.ReadKey();

        }
    }
}
