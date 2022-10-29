using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Problem
{
    class Message
    {
        public string Msg { get; set; }
        public DateTime TimeStamp { get; set; }

        public Message(string msg)
        {
            Msg = msg;
            TimeStamp = DateTime.Now;
        }
    }
}
