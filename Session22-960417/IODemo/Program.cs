using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace IODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var selectedDrive = SelectDrive();
            SelectDirectory(selectedDrive.Name);


            Console.ReadKey();
        }

        private static DriveInfo SelectDrive()
        {
            Console.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            for (int i = 0; i < drives.Length; i++)
            {
                if (drives[i].IsReady)
                    Console.WriteLine($"{i}.{drives[i].Name}\t" +
                        $"{drives[i].TotalSize / 1073741824 }GB\t {drives[i].AvailableFreeSpace / 1073741824}GB" +
                        $"\t{drives[i].DriveFormat}\t{drives[i].DriveType}");
            }
            Console.WriteLine("--------------------");
            Console.Write("Select Drive Index: ");
            return drives[int.Parse(Console.ReadLine())];
        }

        private static void SelectDirectory(string path)
        {
            Console.Clear();
            DirectoryInfo di = new DirectoryInfo(path);
            Console.WriteLine($"Current Directory : {di.FullName}");
            Console.WriteLine("---------------");
            var subDirectories = di.GetDirectories();
            for (int i = 0; i < subDirectories.Length; i++)
            {
                Console.WriteLine($"{i}.{subDirectories[i].Name}");
            }

            var files = di.GetFiles();
            for (int i = subDirectories.Length; i < subDirectories.Length + files.Length; i++)
            {
                Console.WriteLine($"{i}.{files[i - subDirectories.Length].Name}");
            }

            Console.WriteLine("----------------");
            Console.Write("Select Index: ");
            var selectedIndex = int.Parse(Console.ReadLine());
            if (selectedIndex < subDirectories.Length)
                SelectDirectory(subDirectories[selectedIndex].FullName);
            else
            {
                var fileIndex = selectedIndex - subDirectories.Length;
                Process.Start(files[fileIndex].FullName);
            }
        }

    }
}
