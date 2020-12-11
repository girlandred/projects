using System;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            int taskNumber = 0;
            while (true)
            {
                Console.WriteLine("Choose task [1-6]:");
                int.TryParse(Console.ReadLine(), out taskNumber);
                switch (taskNumber)
                {
                    case 1:
                        Console.WriteLine("Opening task 1...");
                        Program1();
                        break;
                    case 2:
                        Program2();
                        Console.WriteLine("Opening task 2...");
                        break;
                    case 3:
                        Console.WriteLine("Opening task 3...");
                        Program3();
                        break;
                    case 4:
                        Console.WriteLine("Opening task 4...");
                        Program4();
                        break;
                    case 5:
                        Console.WriteLine("Opening task 5...");
                        Program5();
                        break;
                    case 6:
                        Console.WriteLine("Opening task 6...");
                        Program6();
                        break;
                    default:
                        Console.WriteLine("Wrong number, try again");
                        break;

                }
            }
        }

        private static void Program1()
        {
            int radius;
            double area;
            // де radius = радiус, а area - площа
            Console.WriteLine("Введiть радiус:");
            radius = Convert.ToInt32(Console.ReadLine());
            area = (3.14) * radius * radius;
            Console.WriteLine("Площа кола = " + area);
            Console.ReadLine();
        }

        private static void Program2()
        {
            int number = 3;
            Console.WriteLine("Введiть довжину сторони куба: ");
            var cube = Convert.ToDouble(Console.ReadLine());
            var result = Math.Pow(cube, number);
            Console.WriteLine("Об'єм куба = " + result);
        }
        private static void Program3()
        {
            Console.WriteLine("Введiть число n, яке бiльше 1 i менше 5: ");
            var n = Convert.ToDouble(Console.ReadLine());
            if (n > 1 && n < 5)
            {
                Console.WriteLine("Введiть число m, котре бiльше 1 i менше 5:");
                var m = Convert.ToDouble(Console.ReadLine());

                if (m > 1 && m < 5)
                {
                    var volume = Math.Pow(m, n);
                    Console.WriteLine("m^n = " + volume);
                }
                else
                {
                    Console.WriteLine("Число не пiдходить");
                }
            }
            else
            {
                Console.WriteLine("Число не пiдходить");
            }
        }
        private static void Program4()
        {
            Console.WriteLine("Введiть дробове число: ");
            var number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат = " + Math.Floor(number));
        }
        private static void Program5()
        {
            Console.WriteLine("Введiть просте число, яке буде бiльшим за 2: ");
            var number = Convert.ToDouble(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Число не пiдходить");
            }
            else if (number < 2)
            {
                Console.WriteLine("Число не пiдходить");
            }
            else
            {
                var result = number / 2;
                Console.WriteLine("Результат = " + Math.Round(result, 2));
            }

        }
        private static void Program6()
        {
            double number;
            while (true)
            {
                number = Getvalue("Введiть число бiльше 0:");
                if (number > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Число не пiдходить 0");
                }
            }
            Console.WriteLine("Результат" + Math.Sqrt((int)++number));
            return;
        }
        private static double Getvalue(string message)
        {
            double value;
            while (true)
            {
                Console.WriteLine(message);
                if (double.TryParse(Console.ReadLine(), out value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Число не пiдходить");
                }
            }
        }
    }
}