using System;

namespace homework4_task3
{
    public class Figure
    {
        public virtual void Draw()
        {
            Console.WriteLine("It's figure class, which realised by virtual method Draw.");
        }
        public readonly int _x;
        public readonly int _y;
        public Figure(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }

    public class Rectangle : Figure
    {
        public Rectangle(int x, int y)
            : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine("It's a rectangle class, realised by method Draw..");
        }
    }

    public class Square : Figure
    {
        public Square(int x, int y)
            : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine("It's a square class, realised by method Draw.");
        }
    }

    class Program
    {
        static void Main()
        {
            Rectangle rectangle = new Rectangle(2, 3);
            Square square = new Square(4, 4);
            Figure figure = new Figure(8, 12);
            rectangle.Draw();
            square.Draw();
            figure.Draw();
            Console.WriteLine("The square edges are: x = {0} y = {1}", square._x, square._y);
        }
    }
}