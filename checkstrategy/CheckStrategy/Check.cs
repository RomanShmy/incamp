using System.Collections.Generic;
using System.Linq;

namespace Checkout
{
    public class Check
    {
        private List<Product> products = new List<Product>();
        private int points = 0;
        private Discount discount;
        public void addProduct(Product product)
        {
            products.Add(product);
        }

        public int getTotalCost() {
            int totalCost = 0;
            foreach (var product in this.products) {
                totalCost += product.price;
            }
            return totalCost;
        }

        public int getTotalPoints()
        {
            return getTotalCost() + points;
        }

        public double getTotalPrice() => getTotalCost() * 1.0 - discount.discount1;



        public void addPoints(int points)
        {
            this.points = points;
        }

        public void addDiscount(Discount discount)
        {
            this.discount = discount;
        }

        public int getCost()
        {
            return products.Sum(a => a.price );
        }

        public List<Product> getProducts()
        {
            return products;
        }
    }
}