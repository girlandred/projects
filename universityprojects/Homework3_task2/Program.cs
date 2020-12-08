using System;

namespace Homework3_task2
{
    class Rectangle
    {
        public int x1 { get; set; }
        public int x2 { get; set; }
        public int y1 { get; set; }
        public int y2 { get; set; }

        double Perimeter, Area;
        int Width, Lenghth;

        public Rectangle(int x1, int y1, int x2, int y2)
        {
            Width = x2 - x1;
            Lenghth = y1 - y2;
        }

        public void RectanglePerimeter()
        {
            Perimeter = 2 * (Width + Lenghth);
            Console.WriteLine("Rectangle's perimeter is {0}", Perimeter);
        }

        public void RectangleArea()
        {
            Area = Width * Lenghth;
            Console.WriteLine("Rectangle's area is {0}", Area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] coordinates = new int[4];
            Console.WriteLine("Enter the x1 coordinate: ");
            coordinates[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y1 coordinate: ");
            coordinates[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the x2 coordinate: ");
            coordinates[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y2 coordinate: ");
            coordinates[3] = int.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(coordinates[0], coordinates[1], coordinates[2], coordinates[3]);
            rect.RectanglePerimeter();
            rect.RectangleArea();
        }
    }
}