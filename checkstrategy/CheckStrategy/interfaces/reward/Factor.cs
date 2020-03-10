using System.Collections.Generic;
using Checkout;

namespace Type
{
    public class Factor : IReward
    {

        private int factor;
        public Factor(int factor)
        {
            this.factor = factor;
        }

        public int calcPoint(Check check)
        {
            int sum = 0;
            foreach (var product in check.getProducts())
            {
                sum += product.price;   
            }
            return (factor - 1) * sum;
        }

    }
}