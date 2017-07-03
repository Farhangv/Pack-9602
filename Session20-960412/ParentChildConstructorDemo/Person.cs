using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentChildConstructorDemo
{
    class Person
    {
        public Person(string _name, string _family)
        {
            Console.WriteLine("Person Created");
            this.Name = _name;
            this.Family = _family;
        }

        public string Name { get; set; }
        public string Family { get; set; }
    }
}
