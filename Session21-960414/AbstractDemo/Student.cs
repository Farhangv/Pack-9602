using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Student:Person
    {
        public int CourseCount { get; set; }
        public int CoursePrice { get; set; }

        public override double GetBalance()
        {
            return CourseCount * CoursePrice * -1;
        }
    }
}
