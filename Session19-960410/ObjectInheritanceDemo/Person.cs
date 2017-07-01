using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInheritanceDemo
{
    class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public override int GetHashCode()
        {
            return PersonId;
        }

        public override string ToString()
        {
            return $"{PersonId}.{Name} {Family}";
        }

        public override bool Equals(object obj)
        {
            return this.GetHashCode() == obj.GetHashCode();
        }

    }
}
