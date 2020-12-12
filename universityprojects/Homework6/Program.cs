using System;
using System.Linq;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            int taskNumber = 0;
            while (true)
            {
                Console.WriteLine("Choose task [1-5]:");
                int.TryParse(Console.ReadLine(), out taskNumber);
                switch (taskNumber)
                {
                    case 1:
                        Program1();
                        Console.WriteLine("Opening task 1");
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
                    default:
                        Console.WriteLine("Wrong number, try again");
                        break;

                }
            }
        }
        private static void Program1()
        {
            Console.WriteLine("Array consist of: ");
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (int)Math.Pow(arr[i], 3);
            }
            Console.WriteLine("Array is: ");
            Console.WriteLine("{0}", string.Join(", ", arr));
        }

        static int Prime(int[] array)
        {
            int HowMuchPrimes = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 1)
                {
                    for (var j = 2u; j < array[i]; j++)
                    {
                        if (array[i] % j == 0)
                        {
                            HowMuchPrimes--;
                            break;
                        }
                    }
                }
                else HowMuchPrimes--;
            }
            return HowMuchPrimes;
        }

        private static void Program2()
        {
            Console.WriteLine("Enter the array elements:");
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Console.WriteLine("There are some prime numbers. {0} ", Prime(arr));
        }

        static void Symetry(int[] array)
        {
            bool symetry = true;
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] == array[array.Length - i - 1])
                {
                    symetry = true;
                    continue;
                }
                else
                {
                    symetry = false;
                    break;
                }
            }
            if (symetry == true) Console.WriteLine("The array is symetric.");
            else Console.WriteLine("The array is not symetric");
        }

        private static void Program3()
        {
            Console.WriteLine("Enter the array elements:");
            int[] arr = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Symetry(arr);
        }

        private static void Program4()
        {
            Console.WriteLine("Enter the size of an array");
            Console.WriteLine("Enter the a number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the b number:");
            int b = int.Parse(Console.ReadLine());
            int[,] arr = new int[a, b];
            Console.WriteLine("\nEnter the elements of the array ({0}x{1}):\n", a, b);
            for (int i = 0; i < a; i++)
            {
                int[] arr_ = new int[b];
                arr_ = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < arr_.Length; j++)
                {
                    arr[i, j] = arr_[j];
                }
            }

            Console.WriteLine("\n Your array is:");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.Write("\n");
            }

            int[] vector = new int[a];
            for (int i = 0; i < a; i++)
            {
                int max = arr[i, 0];
                for (int j = 0; j < b; j++)
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                    vector[i] = (int)max;
                }
            }

            Console.WriteLine("The vector is: " + "[" + "{0}", string.Join(", ", vector) + "]");
        }

        private static void Program5()
        {
            Console.WriteLine("Choose size of the jagged array");
            Console.WriteLine("Enter the element:");

            int m = int.Parse(Console.ReadLine());
            int[][] arr = new int[m][];
            Console.WriteLine("\nEnter the elements of a jagged array:");

            for (int i = 0; i < m; i++)
            {
                int[] arr_ = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                arr[i] = new int[arr_.Length];
                for (int j = 0; j < arr_.Length; j++)
                {
                    arr[i][j] = arr_[j];
                }
            }

            Console.WriteLine("\nYour array is:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0} ", arr[i][j]);
                }
                Console.Write("\n");
            }

            int[] vector = new int[m];
            for (int i = 0; i < arr.Length; i++)
            {
                int max = 0;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > max)
                    {
                        max = arr[i][j];
                    }
                    vector[i] = (int)max;
                }
            }

            Console.WriteLine("\nThe vector is: " + "[" + "{0}", string.Join(", ", vector) + "]");
        }
    }
}