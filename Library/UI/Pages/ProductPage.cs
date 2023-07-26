using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Library.UI.Constants;

namespace Library.UI.Pages
{
    public class ProductPage :Base
    {
        IWebDriver _driver;
        public ProductPage(IWebDriver driver)
        {
            _driver = driver;
        }
        Products productsLocators = new Products();

        public string CartVlaue()
        {
            return _driver.FindElement(By.XPath(productsLocators.ListofProducts)).GetAttribute("text");
        }

        public List<IWebElement> GetProductList()
        {
            return _driver.FindElements(By.XPath(productsLocators.ListofProducts)).ToList<IWebElement>();
        }

        public void ClickAddButton()
        {
            _driver.FindElements(By.XPath(productsLocators.AddProductButton))[0].Click();
        }

        public void ClickRemoveButton()
        {
            _driver.FindElements(By.XPath(productsLocators.RemoveProductButton))[0].Click();
        }

        public bool RemoveButtonDisplayed()
        {
            return _driver.FindElement(By.XPath(productsLocators.RemoveProductButton)).Displayed;
        }

        public bool AddButtonDisplayed()
        {
            return _driver.FindElement(By.XPath(productsLocators.AddProductButton)).Displayed;
        }

        public void ClickOnFilter()
        {
            _driver.FindElement(By.XPath(productsLocators.Filter)).Click();
        }

        public void SelectFilterOptionBasedOnIndex(int index)
        {
            var FilterList = _driver.FindElements(By.XPath(productsLocators.FilterOptions));
            FilterList[index].Click();
        }
    }
}
