using System;
using System.IO;

namespace homework8_task1
{
    class Program
    {
        public static void Main()
        {
            int directorynumerator = 0;
            string DirName = @"C:\Users\Марина Шита\Desktop";
            Console.WriteLine("All subdirectories showing :\n");
            DirectoryInfo directory = new DirectoryInfo(DirName);
            DirectoryInfo[] AllDirectory = directory.GetDirectories();
            foreach (var values in AllDirectory)
            {
                directorynumerator++;
                Console.WriteLine($"{directorynumerator}. {values}");
                DirectoryInfo dirContains = new DirectoryInfo(values.FullName);
                DirectoryInfo[] DirectoryContain = dirContains.GetDirectories();
                int containnumerator = 0;
                foreach (var item in DirectoryContain)
                {
                    containnumerator++;
                    Console.WriteLine($"  {containnumerator}. {item.FullName}");
                }
            }

            Console.WriteLine("\n\nAll files showing:");
            FileInfo[] files = directory.GetFiles();
            foreach (var value in files)
            {
                Console.WriteLine(value);
            }

        }
    }
}