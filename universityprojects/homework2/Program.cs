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
                    Console.WriteLine("Завдання 1-4 :");
                    int.TryParse(Console.ReadLine(), out taskNumber);
                    switch (taskNumber)
                    {
                        case 1:
                            Console.WriteLine("Завдання 1");
                            Program1();
                            break;
                        case 2:
                            Program2();
                            Console.WriteLine("Завдання 2");
                            break;
                        case 3:
                            Console.WriteLine("Завдання 3");
                            Program3();
                            break;
                        case 4:
                            Console.WriteLine("Завдання 4");
                            Program4();
                            break;
                        default:
                        Console.WriteLine("Завдання немає");
                            break;

                    }
                }
            }
            private static void Program1()
            {
                Console.WriteLine("Введiть iм'я:");
                var name = Console.ReadLine();
                Console.WriteLine(name.ToLower());
                Console.ReadLine();
            }
            private static void Program2()
            {
                Console.WriteLine("Введiть перше прiзвище:");
                string surname1 = Console.ReadLine();
                Console.WriteLine("Введiть друге прiзвище:");
                string surname2 = Console.ReadLine();
                Console.WriteLine("Порiвняння прiзвищ:");
                Console.WriteLine("Прiзвища{0}", surname1.Equals(surname2, System.StringComparison.Ordinal) ? " рiвнi" : " не рiвнi");
                if (surname1.Length > surname2.Length)
                {
                    Console.WriteLine("Перше прiзвище > Друге прiзвище");
                }
                else if (surname1.Length < surname2.Length)
                {
                    Console.WriteLine("Друге прiзвище > Перше прiзвище");
                }
                else
                {
                    Console.WriteLine("Перше прiзвище = Друге прiзвище");
                }
            }
            private static void Program3()
            {
                Console.WriteLine("Введіть значення:");
                string oldline = Console.ReadLine();
                Console.WriteLine(oldline.Replace('a', 'u'));
            }
            private static void Program4()
            {
                Console.WriteLine("Введiть в рядок: ");
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