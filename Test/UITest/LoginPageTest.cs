using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SwagLabs.Library.UI.Pages;
using static Library.UI.Constants;

namespace Test.UITest
{
    [TestClass]
    public class LoginPageTest 
    {
        private static IWebDriver _driver;
        LoginPage loginPage = new LoginPage(_driver);

        [TestInitialize]
        public void setup()
        {
            loginPage.setup();
        }

        [TestCleanup]
        public void cleanup()
        {
            loginPage.close_Browser();
        }

  

        [TestMethod]
        public void Login()
        {
            //Login
            loginPage.sendUserName("standard_user");
            loginPage.sendPassword("secret_sauce");
            loginPage.login();
        }

        [TestMethod]
        public void LoginwithoutUserName()
        {
            //Provide Password
            loginPage.sendPassword("secret_sauce");
            //Click on login button
            loginPage.login();
            //Verify Error Msg
        }

        [TestMethod]
        public void LoginWithoutPassword()
        {
            //Provide UserName
            loginPage.sendUserName("standard_user");
            //Click on login button
            loginPage.login();
            //Verify Error Msg
        }
    }
}
