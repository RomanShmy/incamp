namespace Checkout
{
    public class Percent : IDiscountRule
    {
        public double quantity {get; }

        public Percent(double quantity)
        {
            this.quantity = quantity;
        }

        public Discount calcDiscount(Check check)
        {
            double discount = 0;
            foreach (var product in check.getProducts())
            {
                discount += product.price * quantity / 100;
            }

            return new Discount(discount);
        }
    }
}