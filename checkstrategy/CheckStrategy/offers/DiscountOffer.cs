using System;
using Condition;

namespace Checkout
{
    public class DiscountOffer : Offer
    {
        private IDiscountRule discount;
        
        public DiscountOffer(ICondition condition, IDiscountRule discount, int countDay = 7) : base(condition)
        {
            this.discount = discount;
            date = DateTime.Now;
            this.countDay = countDay;
        }
        internal override void apply(Check check)
        {
            check.addDiscount(discount.calcDiscount(check));
        }
    }
}