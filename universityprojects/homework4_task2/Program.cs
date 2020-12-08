using System;

namespace homework4_task2
{
    public abstract class Figure
    {
        public abstract void Draw();
        public readonly int _x, _y;
        protected Figure(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }

    public class Square : Figure
    {
        public Square(int x, int y)
            : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine("It's a Square class, which was realised by draw method");
        }
    }

    public class Rectangle : Figure
    {
        public Rectangle(int x, int y)
            : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine("It's a Rectangle class, which was realised by draw method");
        }
    }
    class Program
    {
        static void Main()
        {
            Square squarefigure = new Square(4, 4);
            Rectangle rectanglefigure = new Rectangle(2, 3);
            squarefigure.Draw();
            rectanglefigure.Draw();
            Console.WriteLine("The square edges are : x = {0} y = {1}", squarefigure._x, squarefigure._y);
        }
    }
}