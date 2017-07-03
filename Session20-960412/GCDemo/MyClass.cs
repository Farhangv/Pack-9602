using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDemo
{
    class MyClass
    {
        public static int Count { get; set; }// تعداد اشیا موجود از این کلاس در رم

        public MyClass()
        {
            MyClass.Count++;
        }
        ~MyClass()
        {
            MyClass.Count--;
        }
    }
}
