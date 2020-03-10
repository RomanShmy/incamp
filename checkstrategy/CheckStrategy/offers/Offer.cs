using System;
using System.Collections.Generic;
using Condition;

namespace Checkout
{
    public abstract class Offer
    {
        internal int countDay;
        internal DateTime date;
        internal ICondition condition;

        public Offer(ICondition condition)
        {
            this.condition = condition;
        }
        public bool use(Check check)
        {
            if (!ExpirationDate())
            {
                apply(check);
                return true;
            }

            return false;
        }

        internal abstract void apply(Check check);

        internal bool ExpirationDate()
        {
            return date.AddDays(countDay).CompareTo(DateTime.Now) < 0;
        }
        
    }

}