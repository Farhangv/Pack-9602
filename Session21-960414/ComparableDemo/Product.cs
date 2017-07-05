using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableDemo
{
    class Product:IComparable
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            return this.Name.CompareTo(((Product)obj).Name);
        }
    }
}
