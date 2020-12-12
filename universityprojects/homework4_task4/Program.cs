using System;

namespace homework4_task4
{
    public interface IDrawable
    {
        public void Draw();
    }
    public class Figure : IDrawable
    {
        public virtual void Draw()
        {
            Console.WriteLine("It's a Figure class realised in IDrawable interface by Draw method.");
        }
        public readonly int _x, _y;
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
            Console.WriteLine("It's a Rectangle class realised in IDrawable interface by Draw method.");
        }
    }

    public class Square : Figure
    {
        public Square(int x, int y)
            : base(x, y) { }
        public override void Draw()
        {
            Console.WriteLine("It is a Square class realised in IDrawable interface by Draw method.");
        }
    }

    class Program
    {
        static void Main()
        {
            Square square = new Square(2, 2);
            Rectangle rectangle = new Rectangle(2, 3);
            Figure figure = new Figure(4, 12);
            DrawAll(square, rectangle, figure);
        }
        private static void DrawAll(params IDrawable[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Draw();
            }
        }
    }
}