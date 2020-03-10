using System;
using Condition;

namespace Checkout
{
    public class BonusOffer : Offer
    {

        public BonusOffer(ICondition condition, int countDay = 7) : base(condition){
            this.date = DateTime.Now;
            this.countDay = countDay;
        }
        internal override void apply(Check check)
        {
            condition.doOfferBy(check);
        }
    }
}
 