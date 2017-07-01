using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Student:Person
    {
        public string StudentCode { get; set; }
        public string Field { get; set; }
        public int CourseCount { get; set; }
        public int PricePerCourse { get; set; }

        public override double GetBalance()
        {
            return CourseCount * PricePerCourse * -1;
        }

    }
}
