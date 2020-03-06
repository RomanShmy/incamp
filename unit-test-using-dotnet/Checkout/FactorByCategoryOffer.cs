using System.Transactions;

namespace Checkout
{
    public class FactorByCategoryOffer : Offer
    {
        public Category category { get;}
        public int factor { get; }

        public FactorByCategoryOffer(Category category, int factor)
        {
            this.category = category;
            this.factor = factor;
        }

        public override void apply(Check check)
        {
            int points = check.getCostByCategory(this.category);
            check.addPoints(points * (this.factor - 1));
        }
    }
}