using System;
using System.Collections.Generic;

namespace Checkout
{
    public abstract class Offer
    {
        internal int countDay;
        internal DateTime date;
        internal HashSet<string> products = new HashSet<string>(){"Milk","Bred"};
        public bool use(Check check)
        {
            if (!ExpirationDate())
            {
                apply(check);
                return true;
            }

            return false;
        }

        public abstract void apply(Check check);

        public bool ExpirationDate()
        {
            return date.AddDays(countDay).CompareTo(DateTime.Now) < 0;
        }
        
    }

}