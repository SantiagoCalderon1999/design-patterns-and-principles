using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Solution
{
    class Order : Entity
    {
        public DateTime OrderPlacedOn { get; set; }
        public double TotalValue { get; set; }

    }
}
