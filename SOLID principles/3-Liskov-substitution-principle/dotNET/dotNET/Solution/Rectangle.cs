using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Solution
{
    class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public int ComputeArea()
        {
            return Width * Height;
        }
    }
}
