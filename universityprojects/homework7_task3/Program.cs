using System;
using System.Collections.Generic;

namespace homework7_task3
{
    class Program
    {
        public static List<string> strings;
        static void Main(string[] args)
        {
            strings = new List<string>(100);
            Random random = new Random();
            string temp;

            for (int i = 0; i < 100; i++)
            {
                temp = "";
                for (int j = 0; j < 4; j++)
                {
                    temp += (char)((random.Next() % 26) + 65);
                }

                strings.Add(temp);
            }

            Console.WriteLine("Amount of symbols before filtering: {0}", strings.Count);

            while (strings.FindIndex(l => l[0] == 'Z') != -1)
            {
                strings.RemoveAt(strings.FindIndex(l => l[0] == 'Z'));
            }

            Console.WriteLine("Amount of symbols after filtering: {0}", strings.Count);

            strings.Sort();
            for (int i = 0; i < strings.Count / 2; i++)
            {
                temp = strings[i];
                strings[i] = strings[strings.Count - 1 - i];
                strings[strings.Count - 1 - i] = temp;
            }

            while (true)
            {
                Console.WriteLine("\nEnter nubmer of page: ");
                if (!int.TryParse(Console.ReadLine(), out int pageNumber))
                    break;
                pageNumber--;
                DisplayPage(pageNumber);
            }

            return;
        }
        public static void DisplayPage(int pageNum)
        {
            if (pageNum * 5 > strings.Count
                || pageNum < 0)
            {
                Console.Write("Error. Enter another page");
                return;
            }
            for (int i = pageNum * 5; !(i >= (pageNum * 5) + 5
                                        || i >= strings.Count); i++)
            {
                Console.Write(strings[i] + "  ");
            }

            return;
        }
    }
}