namespace Checkout
{
    public class Discount
    {
        public double discount1 { get; }

        public int discount { get; }

        public Discount(int discount)
        {
            this.discount = discount;
        }

        public Discount(double discount1)
        {
            this.discount1 = discount1;
        }
    }
}