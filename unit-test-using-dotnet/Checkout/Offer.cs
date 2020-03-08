using System;
namespace Checkout
{
    public abstract class Offer
    {
        public bool use(Check check)
        {
            if (!ExpirationDate())
            {
                apply(check);
                return true;
            }

            return false;
        }

        public abstract void apply(Check check);

        public abstract bool ExpirationDate();
        
    }

}