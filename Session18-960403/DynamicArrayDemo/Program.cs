using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[1];
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < names.Length; i++)
                {
                    if(names[i] != null)
                        Console.WriteLine(names[i]);
                }
                Console.WriteLine("-------------------------");
                var name = Console.ReadLine();
                if (names[0] == null)
                {
                    names[0] = name;
                }
                else
                    AddToArray(ref names, name);
            }
        }

        static int AddToArray(ref string[] array, string newItem)
        {
            string[] newArray = new string[array.Length + 1];
            for (int i = 0; i < array.Length; i++)// انتقال اعضای آرایه قبلی به جدید
            {
                newArray[i] = array[i];
            }
            newArray[newArray.Length - 1] = newItem;
            array = newArray;
            return newArray.Length;
        }
    }
}
