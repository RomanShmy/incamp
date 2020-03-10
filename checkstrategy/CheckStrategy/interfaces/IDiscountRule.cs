using System;

namespace Checkout
{
    public interface IDiscountRule
    {
        Discount calcDiscount(Check check);
    }
}
