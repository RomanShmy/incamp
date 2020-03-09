using System;
using System.Transactions;

namespace Checkout
{
    public class FactorByCategoryOffer : Offer
    {
        public Category category { get;}
        public int Factor { get; }

        public FactorByCategoryOffer(Category category, int factor, int countDay = 7)
        {
            this.category = category;
            Factor = factor;
            this.countDay = countDay;
            date = DateTime.Now;
        }

        public override void apply(Check check)
        {
            foreach (var product in check.getProducts())
            {
                if (this.products.Contains(product.title))
                {
                    int points = check.getCostByCategory(category);
                    check.addPoints(points * (this.Factor - 1));
                }
                
            }
            
        }
    }
}