using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Problem
{
    class Order : Entity
    {
        public DateTime OrderPlacedOn { get; set; }
        public double TotalValue { get; set; }

    }
}
