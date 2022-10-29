using System;
using System.Collections.Generic;
using System.Text;

namespace dotNet.Solution
{
    abstract class Subscriber
    {
        protected long SubscriberId;
        protected string Address;
        protected long PhoneNumber;
        protected int BaseRate;

        public abstract double CalculateBill();
    }
}
