using System.Collections.Generic;
using System.Linq;

namespace Checkout
{
    public class Check
    {
        private List<Product> products = new List<Product>();
        private int points = 0;
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

        public void addPoints(int points)
        {
            this.points = points;
        }

        public int getCostByCategory(Category category)
        {
            return products.Where(n => n.category == category).Sum(a => a.price );
        }
    }
}