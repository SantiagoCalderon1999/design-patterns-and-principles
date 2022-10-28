using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Solution
{
    abstract class User : Entity
    {
        public string Name { get; set; }
        public DateTime LastLogin { get; set; }
    }
}
