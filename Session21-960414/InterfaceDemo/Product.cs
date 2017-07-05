using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Product : ICostable, IProvidedByOtherCompany
    {
        public string CompanyName
        {
            get;

            set;
        }

        public int Cost
        {
            get;

            set;
        }
    }
}
