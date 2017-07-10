using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWriterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter("MyFile.txt", true))
            {
                sw.AutoFlush = true;
                sw.WriteLine("AutoFlush From My Application");
                //sw.Flush();
                Console.ReadKey();
                sw.WriteLine("Text After Flush()");
            }//sw.Close();
            Console.ReadKey();
        }
    }
}
