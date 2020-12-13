using System;
using System.IO;

namespace homework8_task2
{
    class Task2
    {
        public static void Main()
        {
            Console.WriteLine("Enter the name of file you want to find: ");
            string request = Console.ReadLine();
            string DirectoryName = @"C:\Users\Марина Шита\Desktop";
            DirectoryInfo directory = new DirectoryInfo(DirectoryName);
            string[] requestedfiles = Directory.GetFiles(DirectoryName, $"*{request}*.txt", SearchOption.AllDirectories);
            if (requestedfiles.Length == 0)
            {
                Console.WriteLine("Can not find file");
            }
            else
            {
                foreach (string file in requestedfiles)
                {
                    Console.WriteLine(file);
                }
            }
        }
    }
}