using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Problem
{
    class MessagePrinter
    {
        public void WriteMessage(Message msg)
        {
            JSONFormatter formatter = new JSONFormatter();
            Console.WriteLine(formatter.Format(msg));
        }
    }
}
