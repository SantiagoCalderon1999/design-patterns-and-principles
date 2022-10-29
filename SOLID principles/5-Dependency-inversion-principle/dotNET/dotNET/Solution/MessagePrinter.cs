using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Solution
{
    class MessagePrinter
    {
        public void WriteMessage(Message msg, Formatter formatter)
        { 
            Console.WriteLine(formatter.Format(msg));
        }
    }
}
