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
    internal class ProductsPageTest : Base
    {
        private static IWebDriver _driver = null;
        ProductPage productPage = new ProductPage(_driver);


        [TestInitialize]
        public override void setup()
        {
            productPage.setup();
        }

        [TestCleanup]
        public void cleanup()
        {
            productPage.close_Browser();
        }

        [TestMethod]
        public void AddDeleteProductFromCart()
        {
            //Add Product to Cart
            string cartValue1 = productPage.CartVlaue();
            var productsList = productPage.GetProductList();
            productPage.ClickAddButton();


            //Verify Product added to the cart
            string cartValue2 = productPage.CartVlaue();
            Assert.AreEqual(cartValue1.Count(), cartValue2.Count()-1);

            //Verfy User able to see Remove Button
            bool val = productPage.RemoveButtonDisplayed(); 
            Assert.IsTrue(val);

            //Delete Product from Cart
            productPage.ClickRemoveButton();
            //Verify Product deleted from the cart
            string cartValue3 = productPage.CartVlaue();
            Assert.AreEqual(cartValue1.Count(), cartValue3.Count());

            //Verfy User able to see Remove Button
            val = productPage.AddButtonDisplayed();
            Assert.IsTrue(val);
        }

        [TestMethod]
        public void VerifyFilterinProductPage()
        {
            // User able to selct filter
            productPage.ClickOnFilter();
            productPage.SelectFilterOptionBasedOnIndex(3);
            //Verify filter is applied
        }

    }
}
