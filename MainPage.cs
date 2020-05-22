using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TestSeleniumBasic
{
    class MainPage
    {
        private IWebDriver driver;
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement searchName => driver.FindElement(By.XPath("//input[@id=\"Name\"]"));
        private IWebElement searchPassword=> driver.FindElement(By.XPath("//input[@id=\"Password\"]"));
        private IWebElement searchBatten => driver.FindElement(By.CssSelector(".btn"));

        public void Login(string user)
        {
            new Actions(driver).Click(searchInput).SendKeys(user).Build().Perform();
            new Actions(driver).Click(searchInput1).SendKeys(user).Build().Perform();
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
        }
    }
}
