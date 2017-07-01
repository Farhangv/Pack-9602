using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[]
                {
                    new Student() { PersonId = 1, Name = "John" , Family = "Doe", Field = "Computer", StudentCode = "ST-1234"},
                    new Teacher() { PersonId = 2, Name = "Sarah", Family = "Smith", LastDegree = "Master", TeacherCode = "T-852"},
                    new Student() { PersonId = 3, Name = "David" , Family = "Doe", Field = "Electronics", StudentCode = "ST-4321" }
                };



            Console.ReadKey();
        }
    }
}
