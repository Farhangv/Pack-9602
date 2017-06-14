using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApplication.Financial.Accounting;

namespace NamespaceDemo
{

    class Program
    {
        static void Main(string[] args)
        {
            //Account.Owner
            //MyApplication.Financial.Accounting.
        }
    }
}

namespace MyApplication
{
    namespace Financial
    {
        namespace Accounting
        {
            class Account
            {
                public static string Owner { get; set; }
            }
        }
    }
    namespace HumanResources
    {

    }
}

namespace MyApplication.Financial.Accounting
{
    class Document
    {
        public static int Code { get; set; }
    }
}
