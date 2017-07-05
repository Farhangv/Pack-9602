using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Teacher:Person
    {
        public int TeachingHours { get; set; }
        public int Rate { get; set; }

        public override double GetBalance()
        {
            return Rate * TeachingHours;
        }
    }
}
