using System;
using Condition;

namespace Checkout
{
    public class BonusOffer : Offer
    {

        private IReward reward;
        
        public BonusOffer(ICondition condition, IReward reward, int countDay = 7) : base(condition)
        {
            this.reward = reward;
            date = DateTime.Now;
            this.countDay = countDay;
        }
        internal override void apply(Check check)
        {
                               
             check.addPoints(reward.calcPoint(check));

        }
    }
}
 