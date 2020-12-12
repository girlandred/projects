using System;

namespace Homework5_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int taskNumber = 0;
            while (true)
            {
                Console.WriteLine("Choose task [1-4]:");
                int.TryParse(Console.ReadLine(), out taskNumber);
                switch (taskNumber)
                {
                    case 1:
                        Console.WriteLine("Opening task 1");
                        Program1();
                        break;
                    case 2:
                        Console.WriteLine("Opening task 2");
                        Program3();
                        break;
                    case 3:
                        Console.WriteLine("Opening task 3");
                        Program4();
                        break;
                    case 4:
                        Console.WriteLine("Opening task 4");
                        Program5();
                        break;
                    default:
                        Console.WriteLine("Wrong number, try again");
                        break;

                }
            }
        }
        public struct Person
        {
            public string _name, _surname;

            public int _age;

            public Person(string name, string surname, int age)
            {
                _name = name;
                _surname = surname;
                _age = age;
            }

            public string HowOld(int n)
            {
                if (n > _age)
                {
                    return $"{_name} {_surname} younger than {n}";
                }
                else if (n < _age)
                {
                    return $"{_name} {_surname} is older than {n}";
                }
                else
                {
                    return $"{_name} {_surname} is {_age} years old";
                }
            }
        }
        private static void Program1()
        {
            Person person;
            string[] argument;
            int n;

            Console.WriteLine("Let's enter NAME, SURNAME and AGE: ");
            argument = Console.ReadLine().Split(' ');
            person = new Person(argument[0], argument[1], int.Parse(argument[2]));
            Console.WriteLine("Enter n: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(person.HowOld(n));
            Console.ReadKey();
        }
        enum Month { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };

        private static void Program3()
        {
            Console.WriteLine("Let's enter number of month! From 0 to 11:");
            int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine("Month is: {0}", Enum.GetName(typeof(Month), n));
        }

        enum Colors { Red = 4, Purple = 2, Cyan = 3, Green = 1, Blue = 15, Brown = 9 }

        private static void Program4()
        {
            Extension.ColorRang();
        }

        public static class Extension
        {
            public static void ColorRang()
            {
                foreach (Colors color in Enum.GetValues(typeof(Colors)))
                {
                    Console.WriteLine(color);
                }
            }

        }
        enum LongRange : long { Max = 9223372036854775807, Min = -9223372036854775808 };
        private static void Program5()
        {
            Console.WriteLine("Min = {0}", (long)LongRange.Min);
            Console.WriteLine("Max = {0}", (long)LongRange.Max);
        }
    }
}