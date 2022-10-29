using System;
using System.Collections.Generic;
using System.Text;

namespace dotNet.Problem
{
    class CallHistory
    {
        public class Call
        {
            public DateTime Begin { get; set; }
            public long Duration { get; set; }
            public long SubscriberId { get; set; }

            public Call(long subscriberId, long duration, DateTime begin)
            {
                Begin = begin;
                Duration = duration;
                SubscriberId = subscriberId;
            }
        }

        private static Dictionary<long, List<Call>> CALLS = new Dictionary<long, List<Call>>();

        public static List<Call> GetCurrentCalls(long subscriberId)
        {
            List<Call> createdList = new List<Call>();
            if (!CALLS.ContainsKey(subscriberId))
            {
                return createdList;
            }
            CALLS.TryGetValue(subscriberId, out createdList);
            return createdList;
        }
    }
}
