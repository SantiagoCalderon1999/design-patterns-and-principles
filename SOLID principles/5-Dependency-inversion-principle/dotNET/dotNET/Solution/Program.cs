using System;

namespace dotNET.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("This is a message");
            MessagePrinter printer = new MessagePrinter();
            printer.WriteMessage(msg, new JSONFormatter());
        }
    }
}
