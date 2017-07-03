using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Person
    {
        public Person(string _name, string _family)
        {
            this.Name = _name;
            this.Family = _family;
        }

        public Person(string _name, string _family, string _nationalCode)
        {
            this.Name = _name;
            this.Family = _family;
            this.NationalCode = _nationalCode;
        }

        public string Name { get; set; }
        public string Family { get; set; }
        public string NationalCode { get; set; }
    }
}
