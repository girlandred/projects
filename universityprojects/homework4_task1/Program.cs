using System;

namespace homework4_task1
{
    public abstract class Figure
    {
        public abstract void Draw();
    }

    public class Square : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("It's a Square class, which was realised by draw method");
        }
    }

    public class Rectangle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("It's a Rectangle class, which was realised by draw method");
        }
    }
    class Program
    {
        static void Main()
        {
            Square squarefigure = new Square();
            Rectangle rectanglefigure = new Rectangle();
            squarefigure.Draw();
            rectanglefigure.Draw();
        }
    }
}