using System;
namespace Checkout
{
    public abstract class Offer
    {
        // private DateTime date;
        
        // public bool use()
        // {
        //     if(ExpirationDate())

        // }
        public abstract void apply(Check check);
        
        // public abstract bool ExpirationDate(int countDay);
        
    }

}