using Library.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Library.UI.Constants;

namespace SwagLabs.Library.UI.Pages
{
    public class LoginPage : Base
    {
        IWebDriver _driver;
        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }
        LoginPageConstants constants = new LoginPageConstants();
        public void login()
        {
            _driver.FindElement(By.XPath(constants.LoginButton)).Click();
        }

        public void sendUserName(string locVal)
        {
            _driver.FindElement(By.XPath(constants.UserName)).SendKeys(locVal);
        }
        public void sendPassword(string locVal)
        {
            _driver.FindElement(By.XPath(constants.Password)).SendKeys(locVal);
        }
    }
}
