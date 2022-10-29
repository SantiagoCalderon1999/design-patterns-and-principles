using System;

namespace dotNET.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 20);
            Console.WriteLine(rectangle.ComputeArea());

            Square square = new Square(10);
            Console.WriteLine(square.ComputeArea());

            UseRectangle(rectangle);

            UseRectangle(square);
        }

        private static void UseRectangle(Rectangle rectangle)
        {
            rectangle.SetHeight(20);
            rectangle.SetWidth(30);
            if (rectangle.GetHeight() != 20) Console.WriteLine("Height Not equal to 20");
            if (rectangle.GetWidth() != 30) Console.WriteLine("Width Not equal to 30");
            Console.WriteLine(rectangle.GetHeight());
        }
    }
}
