using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Library.UI.Constants;

namespace Library.UI.Pages
{
    public class CartPage :Base
    {
        IWebDriver _driver;
        public CartPage(IWebDriver driver)
        {
            _driver = driver;
        }
        Cart cartConstants = new Cart();

        public void NavigateTocartPage()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/cart.html");
        }

        public bool CartLableDisplyed()
        {
            return _driver.FindElement(By.XPath(cartConstants.YourCartLabel)).Displayed;
        }
    }
}
