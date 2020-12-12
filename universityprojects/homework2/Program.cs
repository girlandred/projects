using System;

namespace homework2
{
        class Program
        {
            static void Main(string[] args)
            {
                int taskNumber = 0;
            while (true)
                {
                    Console.WriteLine("Task 1-4 :");
                    int.TryParse(Console.ReadLine(), out taskNumber);
                    switch (taskNumber)
                    {
                        case 1:
                            Console.WriteLine("Task 1");
                            Program1();
                            break;
                        case 2:
                            Program2();
                            Console.WriteLine("Task 2");
                            break;
                        case 3:
                            Console.WriteLine("Task 3");
                            Program3();
                            break;
                        case 4:
                            Console.WriteLine("Task 4");
                            Program4();
                            break;
                        default:
                        Console.WriteLine("There is no task");
                            break;

                    }
                }
            }
            private static void Program1()
            {
                Console.WriteLine("Name:");
                var name = Console.ReadLine();
                Console.WriteLine(name.ToLower());
                Console.ReadLine();
            }
            private static void Program2()
            {
                Console.WriteLine("First surname:");
                string surname1 = Console.ReadLine();
                Console.WriteLine("Second surname:");
                string surname2 = Console.ReadLine();
                Console.WriteLine("Which longer:");
                Console.WriteLine("Surnames{0}", surname1.Equals(surname2, StringComparison.Ordinal) ? " equale" : " not equale");
                if (surname1.Length > surname2.Length)
                {
                    Console.WriteLine("First surname > Second surname");
                }
                else if (surname1.Length < surname2.Length)
                {
                    Console.WriteLine("Second surname > First surname ");
                }
                else
                {
                    Console.WriteLine("First surname = Second surname");
                }
            }
            private static void Program3()
            {
                Console.WriteLine("Enter line:");
                string oldline = Console.ReadLine();
                Console.WriteLine(oldline.Replace('a', 'u'));
            }
            private static void Program4()
            {
                Console.WriteLine("Enter line: ");
                string line = Console.ReadLine();
            string[] abcorder = line.Split(new char[] { ' ' });
            Array.Sort(abcorder);
            foreach (string words in abcorder)
            {
                Console.WriteLine(words);
            }
        }
    }
}