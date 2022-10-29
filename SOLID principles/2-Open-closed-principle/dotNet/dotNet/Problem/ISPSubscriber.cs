using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace dotNet.Problem
{
    class ISPSubscriber
    {

        public long SubscriberId { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public int BaseRate { get; set; }
        public long FreeUsage { get; set; }

        public ISPSubscriber()
        {

        }

        public double calculateBill()
        {
            List<InternetSessionHistory.InternetSession> sessions = InternetSessionHistory.GetCurrentSessions(SubscriberId);
            long totalData = sessions.Sum(session => session.DataUsed);
            long chargeableData = totalData - FreeUsage;
            return chargeableData * BaseRate / 100;
        }
    }
}
