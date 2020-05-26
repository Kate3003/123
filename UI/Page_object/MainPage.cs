using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestSeleniumBasic.Business_object;

namespace TestSeleniumBasic
{
    class MainPage
    {
        private IWebDriver driver;
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void Login(MainPage mainPage)
        {
            throw new NotImplementedException();
        }

        private IWebElement searchName => driver.FindElement(By.XPath("//input[@id=\"Name\"]"));
        private IWebElement searchPassword=> driver.FindElement(By.XPath("//input[@id=\"Password\"]"));
        private IWebElement searchBatten => driver.FindElement(By.CssSelector(".btn"));

        public void Login(User user)
        {
            new Actions(driver).Click(searchName).SendKeys(user.SearchText).Build().Perform();
            new Actions(driver).Click(searchPassword).SendKeys(user.SearchText).Build().Perform();
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
        }
    }
}
