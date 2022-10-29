using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace dotNet.Solution
{
    class PhoneSubscriber : Subscriber
    {
        public override double CalculateBill()
        {
            List<CallHistory.Call> sessions = CallHistory.GetCurrentCalls(SubscriberId);
            long totalDuration = sessions.Sum(element => element.Duration);
            return totalDuration * BaseRate / 100;
        }
    }
}
