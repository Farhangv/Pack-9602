using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyDemo
{
    class Student
    {
        private string name;
        public string Name
        {
            get {
                return this.name;
            }

            set {
                if (value.Length > 2)
                    this.name = value;
            }
        }

        private string family;

        public string Family
        {
            get { return family; }
            set { family = value; }
        }


        private string nationalCode;

        public string NationalCode
        {
            get {
                return $"{this.nationalCode.Substring(0,3)}-{this.nationalCode.Substring(3,6)}-{this.nationalCode.Substring(9,1)}";
            }
            set {
                if(value.Length == 10 && value[0] == '0')
                    nationalCode = value;
            }
        }

        //public DateTime BirthDate { get; set; }
        
        public DateTime BirthDate { get; set; }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - this.BirthDate.Year;
            }
        }

    }
}
