using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Solution
{
    class Square : IShape
    {
        public int Side { get; set; }

        public Square(int side)
        {
            Side = side;
        }
        public int ComputeArea()
        {
            return Side * Side;
        }
    }
}
