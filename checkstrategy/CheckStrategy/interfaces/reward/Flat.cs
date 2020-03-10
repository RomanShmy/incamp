using System.Collections.Generic;
using Checkout;

namespace Type
{
    public class Flat : IReward
    {
        private int points;
        private int totalCost;
        private HashSet<string> products = new HashSet<string>(){"Milk","Bred"};



        public Flat(int totalCost, int points)
        {
            this.totalCost = totalCost;
            this.points = points;
        }


        public int calcPoint(Check check)
        {
            foreach (var product in check.getProducts())
            {
                if (this.totalCost <= check.getTotalCost() && products.Contains(product.title))
                {
                    return points;
                }
            }
            
            return 0;
        }
    }
}