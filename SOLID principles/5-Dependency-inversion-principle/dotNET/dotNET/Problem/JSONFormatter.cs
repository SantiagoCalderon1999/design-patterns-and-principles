using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace dotNET.Problem
{
    class JSONFormatter : Formatter
    {
        public string Format(Message message)
        {
            return JsonConvert.SerializeObject(message);
        }
    }
}
