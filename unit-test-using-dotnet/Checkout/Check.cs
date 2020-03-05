using System.Collections.Generic;

namespace checkout
{
    public class Check
    {
        public List<Product> products;
        public int totalCost;
        public int getTotalCost()
        {
            return totalCost;
        }
    }
}