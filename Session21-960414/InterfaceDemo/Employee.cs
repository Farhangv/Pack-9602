using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Employee : ICostable
    {
        public int Cost
        {
            get;

            set;
        }

        public string Name { get; set; }
        public string Family { get; set; }
    }
}
