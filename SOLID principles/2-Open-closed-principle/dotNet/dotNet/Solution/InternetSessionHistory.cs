using System;
using System.Collections.Generic;
using System.Text;

namespace dotNet.Solution
{
    class InternetSessionHistory
    {
        public class InternetSession
        {
            public DateTime Begin { get; set; }
            public long SubscriberId { get; set; }
            public long DataUsed { get; set; }

            public InternetSession(long subscriberId, DateTime begin, long dataUsed)
            {
                Begin = begin;
                DataUsed = dataUsed;
                SubscriberId = subscriberId;
            }
        }

        private static Dictionary<long, List<InternetSession>> SESSIONS = new Dictionary<long, List<InternetSession>>();

        public static List<InternetSession> GetCurrentSessions(long subscriberId)
        {
            List<InternetSession> internetSessionList = new List<InternetSession>()
            if (!SESSIONS.ContainsKey(subscriberId))
            {
                return internetSessionList;
            }
            SESSIONS.TryGetValue(subscriberId,out internetSessionList);
            return internetSessionList;
        }
    }
}
