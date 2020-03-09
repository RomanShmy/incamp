using System;

namespace Checkout
{
    public class DiscountOffer : Offer
    {
        private int discount;
        
        public DiscountOffer(int discount, int countDay = 7)
        {
            this.discount = discount;
            date = DateTime.Now;
            this.countDay = countDay;
        }
        public override void apply(Check check)
        {
            foreach (var product in check.getProducts())
            {
                int price = product.price;
                if (products.Contains(product.title))
                {
                    product.price -= price * discount / 100;
                }
            }
        }
    }
}