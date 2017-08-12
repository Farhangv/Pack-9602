using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLInjectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();
            var password = Console.ReadLine();

            var sql = "SELECT * FROM TABLE Users WHERE [Username] = '" + username + "' AND [Password] = '" + password + "';";
            //var sql = "SELECT * FROM TABLE Users WHERE [Username] = '' OR '1' = '1';--' AND [Password] = '" + password + "';";

            //username : ' OR '1' = '1';--
            ///


        }
    }
}
