using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchDemo
{
    class InvalidAgeException:Exception
    {
        public override string Message
        {
            get
            {
                return "Sene Vared Shode Eshtebah Ast";
            }
        }
    }
}
