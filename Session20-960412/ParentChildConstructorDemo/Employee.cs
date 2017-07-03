using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParentChildConstructorDemo
{
    class Employee:Person
    {
        public Employee(string _name, string _family)
            :base(_name, _family)
        {
            Console.WriteLine("Employee Created");
        }
    }
}
