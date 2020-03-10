using Checkout;

namespace Condition
{
    public class TotalCost : ICondition
    {
        private IReward reward;
        private IDiscountRule discount;
        public TotalCost(IReward reward)
        {
            this.reward = reward;
        }

        public TotalCost(IDiscountRule discount)
        {
            this.discount = discount;
        }
        void ICondition.doOfferBy(Check check)
        {
            if(discount == null)
            {
                check.addPoints(reward.calcPoint(check));        
            }
            else
            {
                check.addDiscount(discount.calcDiscount(check));
            }            

            
        }
    }
}