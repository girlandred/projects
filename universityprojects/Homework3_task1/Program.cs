using System;

namespace Homework3_task1
{
        class Rectangle
        {
            private double Perimeter, Area;
            public int x1, x2, y1, y2;
            private int Width, Length;
            public void Parameters()
            {
                Console.WriteLine("Let's enter some coordinates! The x1 coordinate is: ");
                x1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Let's enter some coordinates! The y1 coordinate is: ");
                y1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Let's enter some coordinates! The x2 coordinate is: ");
                x2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Let's enter some coordinates! The y1 coordinate is: ");
                y2 = int.Parse(Console.ReadLine());
                Width = x2 - x1;
                Length = y1 - y2;
            }

            public void RectanglesPerimeter()
            {
                Perimeter = 2 * (Width + Length);
                Console.WriteLine("Rectangle's area is {0}", Perimeter);
            }

            public void RectanglesArea()
            {
                Area = Width * Length;
                Console.WriteLine("Rectangle's area is {0}", Area);
            }


        }
        class Program
        {
            static void Main(string[] args)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Parameters();
                rectangle.RectanglesPerimeter();
                rectangle.RectanglesArea();
            }
        }
    }