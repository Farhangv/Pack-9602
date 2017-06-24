using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Student
    {
        public int id;
        private string name;
        public string family;
        private DateTime birthDate;
        public string nationalCode;
        public string phone;

        public void WriteStudent()
        {
            //Console.WriteLine($"Student : {id} {name} {family}");
            Console.WriteLine($"Student : {this.id} {this.GetName()} {this.family}");
        }

        public void SetBirthDate(DateTime _birthDate)
        {
            if (DateTime.Now > _birthDate)
                this.birthDate = _birthDate;
        }

        public DateTime GetBirthDate()
        {
            return this.birthDate;
        }

        public void SetName(string _name)
        {
            if (_name.Length > 2)
                this.name = _name;
        }
        public string GetName()
        {
            if (this.name == "john")
                return $"Mr.{name}";
            else
                return name;
        }
    }
}
