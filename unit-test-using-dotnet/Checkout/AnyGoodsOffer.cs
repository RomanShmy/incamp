using System;
using System.Collections.Generic;

namespace Checkout
{
    public class AnyGoodsOffer : Offer
    {
        public readonly int totalCost;
        public readonly int points;

        public AnyGoodsOffer(int totalCost, int points, int countDay = 7)
        {
            this.totalCost = totalCost;
            this.points = points;
            this.countDay = countDay;
            date = DateTime.Now;
        }

        public override void apply(Check check)
        {
            foreach (var product in check.getProducts())
            {
                if (this.totalCost <= check.getTotalCost() && this.products.Contains(product.title))
                {
                    check.addPoints(this.points);
                }
            }
        }

        
    }
}