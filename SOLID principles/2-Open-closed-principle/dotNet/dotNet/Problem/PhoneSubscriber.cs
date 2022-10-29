using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace dotNet.Problem
{
    class PhoneSubscriber
    {
        public long SubscriberId { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public int BaseRate { get; set; }

        public double CalculateBill()
        {
            List<CallHistory.Call> sessions = CallHistory.GetCurrentCalls(SubscriberId);
            long totalDuration = sessions.Sum(element => element.Duration);
            return totalDuration * BaseRate / 100;
        }
    }
}
