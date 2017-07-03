using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCreatingDemo
{
    delegate void InvalidAgeEneteredHandler();
    class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set {
                if (value > 0)
                    age = value;
                else
                {
                    //اتفاق انداختن رویداد
                    InvalidAgeEntered();
                }
            }
        }

        public event InvalidAgeEneteredHandler InvalidAgeEntered;
    }
}
