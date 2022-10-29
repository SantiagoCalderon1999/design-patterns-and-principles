using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Problem
{
    class Rectangle
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int GetWidth()
        {
            return width;
        }

        public virtual void SetWidth(int width)
        {
            this.width = width;
        }

        public int GetHeight()
        {
            return height;
        }

        public virtual void SetHeight(int height)
        {
            this.height = height;
        }

        public int ComputeArea()
        {
            return width * height;
        }
    }
}
