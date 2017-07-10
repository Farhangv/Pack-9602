using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebClientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient wc = new WebClient();
            wc.BaseAddress = "https://www.tutorialspoint.com/";
            var html = wc.DownloadString("csharp/csharp_regular_expressions.htm");
            //using (StreamWriter sw = new StreamWriter("regex.txt"))
            //{
            //    sw.WriteLine(html);
            //}

            Regex re = new Regex("href\\s*=\\s*(?:[\"'](?<1>[^\"']*)[\"']|(?<1>\\S+))");
            var matches = re.Matches(html);
            foreach (Match m in matches)
            {
                Console.WriteLine(m.Groups[1]);
            }
            
            Console.ReadKey();


        }
    }
}
