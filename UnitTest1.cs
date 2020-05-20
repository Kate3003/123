using System;
using System.Net;
using System.Net.WebSockets;
using System.Threading.Channels;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestSeleniumBasic
{
    public class Tests
    {
        private IWebDriver driver;
        
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [Test]
        public void Login()
        {
            driver.FindElement(By.XPath("//input[@id=\"Name\"]")).SendKeys("user");
            driver.FindElement(By.XPath("//input[@id=\"Password\"]")).SendKeys("user");
            driver.FindElement(By.CssSelector(".btn")).Click();
            Assert.AreEqual("Home page", driver.FindElement(By.XPath("//h2")).Text);
        }

        [Test]
        public void Logout()
        {
            driver.FindElement(By.XPath("//input[@id=\"Name\"]")).SendKeys("user");
            driver.FindElement(By.XPath("//input[@id=\"Password\"]")).SendKeys("user");
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.XPath("//a[contains(text(),'Logout')]")).Click();
            Assert.AreEqual("Login", driver.FindElement(By.XPath("//h2")).Text);
        }

        [Test]
        public void AddProduct()
        {
            driver.FindElement(By.XPath("//input[@id=\"Name\"]")).SendKeys("user");
            driver.FindElement(By.XPath("//input[@id=\"Password\"]")).SendKeys("user");
            driver.FindElement(By.CssSelector(".btn")).Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'All Products')])[2]")).Click();
            driver.FindElement(By.LinkText("Create new")).Click();
            driver.FindElement(By.XPath("//input[@id=\"ProductName\"]")).SendKeys("Pie");
            driver.FindElement(By.XPath("//select[@id=\"CategoryId\"]")).SendKeys("Confections");
            driver.FindElement(By.XPath("//select[@id=\"SupplierId\"]")).SendKeys("Pavlova, Ltd.");
            driver.FindElement(By.XPath("//input[@id=\"UnitPrice\"]")).SendKeys("12");
            driver.FindElement(By.XPath("//input[@id=\"QuantityPerUnit\"]")).SendKeys("31-450 g boxes");
            driver.FindElement(By.XPath("//input[@id=\"UnitsInStock\"]")).SendKeys("28");
            driver.FindElement(By.XPath("//input[@id=\"UnitsOnOrder\"]")).SendKeys("0");
            driver.FindElement(By.XPath("//input[@id=\"ReorderLevel\"]")).SendKeys("11");
            driver.FindElement(By.CssSelector(".btn")).Click();
            Assert.IsTrue(driver.FindElement(By.XPath("//*[text()=\"Pie\"]")).Displayed);
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
