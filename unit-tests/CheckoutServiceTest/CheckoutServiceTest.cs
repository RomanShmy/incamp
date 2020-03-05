using Checkout;
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
            milk = new Product(7, "Milk");
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
            checkoutService.addProduct(milk);
            checkoutService.addProduct(bred);
            Check check = checkoutService.closeCheck();
            Assert.Equal(10,check.getTotalPoints());
        }
    }
}