using System;

namespace Homework5_task2
{ 
struct Rectangle : ICoordinate, ISize
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int X { get; set; }
    public int Y { get; set; }


    public Rectangle(int width, int height, int x, int y)
    {
        Width = width;
        Height = height;
        X = x;
        Y = y;

    }
    public int Getperimetr(int width, int height)
    {
        return (width + height) * 2;
    }

}
class Program2
{
    static void Main()
    {
        Rectangle rectangle;
        string[] parameters;
        int Getperimetr;
        Console.WriteLine("Let's enter some parameters, like WIDTH, HEIGHT, X and Y coordinates: ");
        parameters = Console.ReadLine().Split(' ');

        rectangle = new Rectangle(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
        Getperimetr = (int.Parse(parameters[0]) + int.Parse(parameters[1])) * 2;

        Console.WriteLine($"Rectangle width: {rectangle.Width}\n");
        Console.WriteLine($"Rectangle height: {rectangle.Height}\n");
        Console.WriteLine($"Rectangle x : {rectangle.X}\n");
        Console.WriteLine($"Rectangle y : {rectangle.Y}\n");
        Console.WriteLine($"Perimetr is: {Getperimetr} ");
        Console.ReadKey();

    }
}
}