using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Problem
{
    class Square : Rectangle
    {
        public Square(int side) : base (side, side)
        { 
        }

        public override void SetWidth(int width)
        {
            SetSide(width);
        }

        public override void SetHeight(int width)
        {
            SetSide(width);
        }

        public void SetSide(int side)
        {
            base.SetWidth(side);
            base.SetHeight(side);
        }
    }
}
