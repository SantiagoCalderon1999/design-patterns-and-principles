using System;

namespace dotNET.Solution
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
        }

        private static void UseRectangle(Rectangle rectangle)
        {
            rectangle.Height = 20;
            rectangle.Width = 30;
            if (rectangle.Height != 20) Console.WriteLine("Height Not equal to 20");
            if (rectangle.Width != 30) Console.WriteLine("Width Not equal to 30");
            Console.WriteLine(rectangle.Height);
        }
    }
}
