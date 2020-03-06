namespace Checkout
{
    public class AnyGoodsOffer : Offer
    {
        public readonly int totalCost;
        public readonly int points;
        public readonly int countDay;

        public AnyGoodsOffer(int totalCost, int points, int countDay = 7)
        {
            this.totalCost = totalCost;
            this.points = points;
            this.countDay = countDay;
        }

        public override void apply(Check check)
        {
            if (this.totalCost <= check.getTotalCost())
            {
                check.addPoints(this.points);
            }
        }

    }
}