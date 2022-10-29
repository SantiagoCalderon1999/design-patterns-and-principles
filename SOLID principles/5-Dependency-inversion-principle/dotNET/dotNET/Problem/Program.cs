using System;

namespace dotNET.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("This is a message");
            MessagePrinter printer = new MessagePrinter();
            printer.WriteMessage(msg);
        }
    }
}
