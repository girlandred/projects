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
                Console.WriteLine("Choose task 1-6:");
                int.TryParse(Console.ReadLine(), out taskNumber);
                switch (taskNumber)
                {
                    case 1:
                        Console.WriteLine("Opening task 1");
                        Program1();
                        break;
                    case 2:
                        Program2();
                        Console.WriteLine("Opening task 2");
                        break;
                    case 3:
                        Console.WriteLine("Opening task 3");
                        Program3();
                        break;
                    case 4:
                        Console.WriteLine("Opening task 4");
                        Program4();
                        break;
                    case 5:
                        Console.WriteLine("Opening task 5");
                        Program5();
                        break;
                    case 6:
                        Console.WriteLine("Opening task 6");
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
            Console.WriteLine("Radius:");
            radius = Convert.ToInt32(Console.ReadLine());
            area = (3.14) * radius * radius;
            Console.WriteLine("Area = " + area);
            Console.ReadLine();
        }

        private static void Program2()
        {
            int number = 3;
            Console.WriteLine("Cube edge: ");
            var cube = Convert.ToDouble(Console.ReadLine());
            var result = Math.Pow(cube, number);
            Console.WriteLine("Volume cube = " + result);
        }
        private static void Program3()
        {
            Console.WriteLine("Enter 1 < n < 5: ");
            var n = Convert.ToDouble(Console.ReadLine());
            if (n > 1 && n < 5)
            {
                Console.WriteLine("Enter m, > 1, < 5:");
                var m = Convert.ToDouble(Console.ReadLine());

                if (m > 1 && m < 5)
                {
                    var volume = Math.Pow(m, n);
                    Console.WriteLine("m^n = " + volume);
                }
                else
                {
                    Console.WriteLine("Wrong number");
                }
            }
            else
            {
                Console.WriteLine("Wrong number");
            }
        }
        private static void Program4()
        {
            Console.WriteLine("Enter fraction number: ");
            var number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат = " + Math.Floor(number));
        }
        private static void Program5()
        {
            Console.WriteLine("Prime number, >2 : ");
            var number = Convert.ToDouble(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Wrong number");
            }
            else if (number < 2)
            {
                Console.WriteLine("Wrong number");
            }
            else
            {
                var result = number / 2;
                Console.WriteLine("Result = " + Math.Round(result, 2));
            }

        }

        private static void Program6()
        {
            double number;
            while (true)
            {
                number = Getvalue("Enter number > 0:");
                if (number > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong number");
                }
            }
            Console.WriteLine("Result" + Math.Sqrt((int)++number));
            return;
        }
            private static double Getvalue(string warning)
            {
            while (true)
            {
                Console.WriteLine(warning);
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine("Wrong number");
                }
            }
        }
        }
    }