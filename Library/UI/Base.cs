using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Library.UI
{
    public class Base
    {
        IWebDriver driver = null;

        public virtual void setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();
        }

        public virtual void close_Browser()
        {
            driver.Quit();
        }

        public void NavigateToURL(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void AcceptAlert()
        {
            driver.SwitchTo().Alert().Accept();
        }

        public void ClickElementByXpath(string xpath)
        {
            driver.FindElement(By.XPath(xpath)).Click();
        }

        public IWebElement FindElementByXpath(string xpath)
        {
            IWebElement searchElement = driver.FindElement(By.XPath(xpath));
            return searchElement;
        }

        public bool FindElementIsEnabledByXpath(string xpath)
        {
            IWebElement searchElement = driver.FindElement(By.XPath(xpath));
            bool isenabled = searchElement.Enabled;
            return isenabled;
        }

        public IReadOnlyCollection<IWebElement> FindElementsByXpath(string xpath)
        {
            IReadOnlyCollection<IWebElement> searchElement = driver.FindElements(By.XPath(xpath));
            return searchElement;
        }

        public string GetTextByXpath(string xpath)
        {
            IWebElement searchElement = driver.FindElement(By.XPath(xpath));
            return searchElement.Text.ToString();
        }

        public bool SetDataToTextBox(string value, string xpath)
        {
            driver.FindElement(By.XPath(xpath)).Click();
            //var searchTextElement = driver.FindElement(By.XPath(Constants.Constants.HomePage.SearchinputXpath));
            //searchTextElement.Click();
            //searchTextElement.SendKeys(value);

            //driver.FindElement(By.XPath(Constants.Constants.HomePage.SearchinputButtonXpath)).Click();
            return true;
        }

        public string GetPageTitle()
        {
            return driver.Title.ToString();
        }

    }
}
