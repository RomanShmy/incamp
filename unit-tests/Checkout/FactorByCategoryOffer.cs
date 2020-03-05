using System.Transactions;

namespace Checkout
{
    public class FactorByCategoryOffer : AnyGoodsOffer
    {
        public Category category { get;}
        public int factor { get; }

        public FactorByCategoryOffer(Category category, int factor) : base(0,0)
        {
            this.category = category;
            this.factor = factor;
        }
    }
}