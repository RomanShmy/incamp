using System.Collections.Generic;

namespace checkout
{
    public class Check
    {
        private List<Product> products = new List<Product>();
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

        
    }
}