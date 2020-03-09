namespace Checkout
{
    public class Product
    {
        public int price;
        public readonly string title;
        public Category category;

        public Product(int price, string title) : this(price, title, Category.NULL)
        {}

        public Product(int price, string title, Category category)
        {
            this.price = price;
            this.title = title;
            this.category = category;
        }
    }
}