using NUnit.Framework;
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
        private IWebElement searchHomePage => driver.FindElement(By.XPath("//h2"));

        public void Login(User user)
        {
            new Actions(driver).Click(searchName).SendKeys(user.SearchText).Build().Perform();
            new Actions(driver).Click(searchPassword).SendKeys(user.SearchText).Build().Perform();
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
            Assert.AreEqual("Home page", searchHomePage.Text);
        }

        private IWebElement searchLogout => driver.FindElement(By.XPath("//a[contains(text(),'Logout')]"));
        private IWebElement searchLogin => driver.FindElement(By.XPath("//h2"));

        public void Logout(User user)
        {
            searchLogout.Click();
            Assert.AreEqual("Login", searchLogin.Text);
        }
    }
}
