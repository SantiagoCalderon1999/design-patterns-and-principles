using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Solution
{
    class TextFormatter : Formatter
    {
        public string Format(Message message)
        {
            return message.TimeStamp + ":" + message.Msg;
        }
    }
}
