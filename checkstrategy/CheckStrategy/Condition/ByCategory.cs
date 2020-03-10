using Checkout;

namespace Condition
{
    public class ByCategory : ICondition
    {
        private IReward reward;
        private IDiscountRule discount;
        public ByCategory(IReward reward)
        {
            this.reward = reward;
        }

        public ByCategory(IDiscountRule discount)
        {
            this.discount = discount;
        }
        public void doOfferBy(Check check)
        {
            foreach (var product in check.getProducts())
            {
                if (product.category != Category.NULL)
                {
                    if (discount == null)
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
    }
}