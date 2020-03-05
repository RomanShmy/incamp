namespace Checkout
{
    public class Product
    {
        public readonly int price;
        public readonly string title;
        
        public Product(int price, string title){
            this.price = price;
            this.title = title;
        }
    }
}