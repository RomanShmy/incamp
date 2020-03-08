using System;

namespace Checkout
{
    public class AnyGoodsOffer : Offer
    {
        public readonly int totalCost;
        public readonly int points;
        public readonly int countDay;
        public readonly DateTime date;

        public AnyGoodsOffer(int totalCost, int points, int countDay = 7)
        {
            this.totalCost = totalCost;
            this.points = points;
            this.countDay = countDay;
            date = DateTime.Now;
        }

        public override void apply(Check check)
        {
            if (this.totalCost <= check.getTotalCost())
            {
                check.addPoints(this.points);
            }
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