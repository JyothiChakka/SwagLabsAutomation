using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.UI;
using Library.UI.Pages;
using OpenQA.Selenium;
using static Library.UI.Constants;

namespace Test.UITest
{
    [TestClass]
    internal class CartPageTest : Base
    {
        private static IWebDriver _driver;
        Cart CartLocators = new Cart();
        CartPage cartPage = new CartPage(_driver);
        

        [TestInitialize]
        public override void setup()
        {
            cartPage.setup();
        }

        [TestCleanup]
        public void cleanup()
        {
            cartPage.setup();
        }

        [TestMethod]
        public void VerifyCartPageLoaded()
        {
            //navigate to Cart page
            cartPage.NavigateTocartPage();
            bool val = cartPage.CartLableDisplyed();
            Assert.IsTrue(val);
        }

        [TestMethod]
        public void CheckOutCartItems()
        {
            var val = _driver.FindElements(By.XPath(CartLocators.CartItem));

            if(val.Count == 0)
            {
                Assert.IsTrue(true, "Cart is empty please add items to continue");
            }
            else
            {
                _driver.FindElement(By.XPath(CartLocators.CheckoutButton)).Click();
                bool value = _driver.FindElement(By.XPath(CartLocators.YourCartLabel)).Displayed;
                Assert.IsTrue(value);
            }
        }

    }
}
