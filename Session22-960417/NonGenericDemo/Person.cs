using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericDemo
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public override int GetHashCode()
        {
            return this.Id;
        }
        public override bool Equals(object obj)
        {
            return this.GetHashCode() == obj.GetHashCode();
        }
    }
}
