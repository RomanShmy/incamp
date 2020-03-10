using Checkout;
using Type;
using Xunit;

namespace CheckoutServiceTest
{
    public class UnitTest1
    {
        private Product milk;
        private Product bred;
        private CheckoutService checkoutService;

        public UnitTest1()
        {
            milk = new Product(7, "Milk", Category.MILK);
            bred = new Product(3, "Bred");
            checkoutService = new CheckoutService();
            checkoutService.openCheck();
        }
        
        [Fact]
        public void closeCheck__withOneProduct()
        {
            checkoutService.addProduct(milk);
            Check check = checkoutService.closeCheck();
            Assert.Equal(7, check.getTotalCost());   
        }

        [Fact]
        public void closeCheck__withTwoProduct()
        {
            checkoutService.addProduct(milk);
            checkoutService.addProduct(bred);
            Check check = checkoutService.closeCheck();
            Assert.Equal(10,check.getTotalCost());   
        }
        
        [Fact]
        void addProduct__whenCheckIsClosed__opensNewCheck() {

            checkoutService.addProduct(milk);
            Check milkCheck = checkoutService.closeCheck();
            Assert.Equal(7, milkCheck.getTotalCost());

            checkoutService.addProduct(bred);
            Check bredCheck = checkoutService.closeCheck();
            Assert.Equal(3, bredCheck.getTotalCost());
        }


        [Fact]
        public void closeCheck__calcTotalPoints()
        {
            milk = new Product(7, "Milk");
            bred = new Product(3, "Bred");
            checkoutService.addProduct(milk);
            checkoutService.addProduct(bred);
            Check check = checkoutService.closeCheck();
            Assert.Equal(10,check.getTotalPoints());
        }
        
        [Fact]
        public void useOffer__bounusOfferAddPoint()
        {
            checkoutService.addProduct(milk);
            checkoutService.addProduct(bred);
            checkoutService.useOffer(new BonusOffer(new Flat(6,2)));
            Check check = checkoutService.closeCheck();
            Assert.Equal(12,check.getTotalPoints());
        }

        [Fact]
        public void useOffer__bounusOfferAddPoint__doNothing()
        {
            checkoutService.addProduct(bred);
            checkoutService.useOffer(new BonusOffer(new Flat(6,2)));
            Check check = checkoutService.closeCheck();
            Assert.Equal(3,check.getTotalPoints());
        }

        [Fact]
        public void useOffer__bounusOfferFactorPoint()
        {
            checkoutService.addProduct(milk);
            checkoutService.addProduct(bred);
            checkoutService.useOffer(new BonusOffer(new Factor(2)));
            checkoutService.addProduct(new Product(10, "Water"));
            Check check = checkoutService.closeCheck();
            Assert.Equal(30,check.getTotalPoints());
        }
        
        [Fact]
        public void useOffer__discountOffer__totalPrice()
        {
            checkoutService.addProduct(bred);
            checkoutService.useOffer(new DiscountOffer(new Percent(20)));
            Check check = checkoutService.closeCheck();
            Assert.Equal(2.4, check.getTotalPrice());
        }

 
        
    }
    
}