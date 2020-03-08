using System;
using System.Transactions;

namespace Checkout
{
    public class FactorByCategoryOffer : Offer
    {
        public Category category { get;}
        public int Factor { get; }
        
        public readonly int countDay;
        public readonly DateTime date;

        public FactorByCategoryOffer(Category category, int factor, int countDay = 7)
        {
            this.category = category;
            Factor = factor;
            this.countDay = countDay;
            date = DateTime.Now;
        }

        public override void apply(Check check)
        {
            int points = check.getCostByCategory(category);
            check.addPoints(points * (this.Factor - 1));
        }

        public override bool ExpirationDate()
        {
            if (date.AddDays(countDay).CompareTo(DateTime.Now) < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}