using System;
using System.Collections.Generic;

namespace Checkout
{
    public class CheckoutService
    {
        private Check check;

        List<Offer> offers;
        public void openCheck()
        {
            check = new Check();
            offers = new List<Offer>();
        }

        public void addProduct(Product product)
        {

            
            if (check == null)
            {
                openCheck();
            }
            check.addProduct(product);
        
        }

        public Check closeCheck()
        {
            foreach (var offer in offers)
            {
                offer.apply(check);
            }
            Check closedCheck = check;
            check = null;
            return closedCheck;
        }

        public void useOffer(Offer offer)
        {
            offers.Add(offer);
        }    
    }
}