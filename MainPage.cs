﻿using OpenQA.Selenium;
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
        private IWebElement searchInput => driver.FindElement(By.XPath("//input[@id=\"Name\"]"));
        private IWebElement searchInput1=> driver.FindElement(By.XPath("//input[@id=\"Password\"]"));
        private IWebElement searchBtn => driver.FindElement(By.CssSelector(".btn"));

        public void SearchForHost(string user)
        {
            new Actions(driver).Click(searchInput).SendKeys(user).Build().Perform();
            new Actions(driver).Click(searchInput1).SendKeys(user).Build().Perform();
            new Actions(driver).SendKeys(Keys.Enter).Build().Perform();
        }
    }
}