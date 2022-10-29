using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace dotNet.Solution
{
    class ISPSubscriber : Subscriber
    {
        public int FreeUsage { get; set; }
        public override double CalculateBill()
        {
            List<InternetSessionHistory.InternetSession> sessions = InternetSessionHistory.GetCurrentSessions(SubscriberId);
            long totalData = sessions.Sum(session => session.DataUsed);
            long chargeableData = totalData - FreeUsage;
            return chargeableData * BaseRate / 100;
        }
    }
}
