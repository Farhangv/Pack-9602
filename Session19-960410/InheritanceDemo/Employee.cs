using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Employee:Person
    {
        public int WorkingHours { get; set; }
        public int Rate { get; set; }

        public override double GetBalance()
        {
            return WorkingHours * Rate;
        }
    }
}
