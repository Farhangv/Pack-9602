using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPhoneBookDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Specify Size of Phone Book:");
            int size = int.Parse(Console.ReadLine());
            string[] names = new string[size];
            string[] families = new string[size];
            string[] phones = new string[size];
            string[] cellPhones = new string[size];
            DateTime[] birthDates = new DateTime[size];
            var currentAddIndex = 0;
            while (true)
            {
                Console.Clear();

                for (int i = 0; i < size; i++)
                {
                    if(names[i] != null)
                        Console.WriteLine($"{i} . {names[i]},{families[i]},{phones[i]},{cellPhones[i]},{birthDates[i].ToShortDateString()}");
                }

                Console.WriteLine("--------------------");
                Console.WriteLine("1.Add\n2.Edit\n3.Delete\n4.Exit");

                Console.WriteLine("------------");
                Console.Write("Pick An Item From Menu:");
                var selectedItem = int.Parse(Console.ReadLine());

                switch (selectedItem)
                {
                    case 1:
                        if (currentAddIndex >= size)
                        {
                            Console.WriteLine("Phone Book Is Full!");
                            Console.ReadKey();
                            break;
                        }

                        Console.Write("Name:");
                        names[currentAddIndex] = Console.ReadLine();
                        Console.Write("Family:");
                        families[currentAddIndex] = Console.ReadLine();
                        Console.Write("Phone:");
                        phones[currentAddIndex] = Console.ReadLine();
                        Console.Write("CellPhone:");
                        cellPhones[currentAddIndex] = Console.ReadLine();
                        Console.Write("Birth Date:");
                        birthDates[currentAddIndex] = DateTime.Parse(Console.ReadLine());
                        currentAddIndex++;
                        break;

                    case 2:
                        Console.WriteLine("Enter Contact Index:");
                        var selectedIndex = int.Parse(Console.ReadLine());
                        Console.Write("Name:");
                        names[selectedIndex] = Console.ReadLine();
                        Console.Write("Family:");
                        families[selectedIndex] = Console.ReadLine();
                        Console.Write("Phone:");
                        phones[selectedIndex] = Console.ReadLine();
                        Console.Write("CellPhone:");
                        cellPhones[selectedIndex] = Console.ReadLine();
                        Console.Write("Birth Date:");
                        birthDates[selectedIndex] = DateTime.Parse(Console.ReadLine());
                        break;

                    case 4:
                        return;
                }
            }

        } 
    }
}
