using System;

namespace Homework3_task3
{
    class Circle
    {
        public int Radius { get; set; }
        private double Lenght, Area;
        const double Pi = 3.14;

        public Circle(int radius)
        {
            Radius = radius;
        }

        public void CircleLenght()
        {
            Lenght = 2 * Pi * Radius;
            Console.WriteLine("Circle's lenght is {0}", Lenght);
        }

        public void CircleArea()
        {
            Area = Pi * Radius * Radius;
            Console.WriteLine("Circle's area is {0}", Area);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle: ");
            int radius = int.Parse(Console.ReadLine());
            Circle circle = new Circle(radius);
            circle.CircleLenght();
            circle.CircleArea();
        }
    }
}