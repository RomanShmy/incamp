using System.Collections.Generic;
using Checkout;

namespace Condition
{
    public class ByTitle : ICondition
    {
        private HashSet<string> products = new HashSet<string>(){"Milk", "Bred"};
        private IReward reward;
        private IDiscountRule discount;
        public ByTitle(IReward reward)
        {
            this.reward = reward;
        }

        public ByTitle(IDiscountRule discount)
        {
            this.discount = discount;
        }

    
        public void doOfferBy(Check check)
        {
            foreach (var product in check.getProducts())
            {
                if(products.Contains(product.title))
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