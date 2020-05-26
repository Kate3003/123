using System;
using System.Net;
using System.Net.WebSockets;
using System.Threading.Channels;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestSeleniumBasic.Business_object;
using TestSeleniumBasic.Service.UI;

namespace TestSeleniumBasic
{
    public class Tests
    {
        private IWebDriver driver;
        private MainPage mainPage;
        //private AllProductsPage allProductsPage;
        private Product pie = new Product("Pie", "Confections", "Pavlova, Ltd.", "12", "31-450 g boxes", "28", "0", "11");
        private User user = new User("user");
        
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
            mainPage = new MainPage(driver);
            mainPage.Login(user);
            Assert.AreEqual("Home page", driver.FindElement(By.XPath("//h2")).Text);
        }

        [Test]
        public void Logout()
        {
            mainPage = new MainPage(driver);
            mainPage.Login(user);
            driver.FindElement(By.XPath("//a[contains(text(),'Logout')]")).Click();
            Assert.AreEqual("Login", driver.FindElement(By.XPath("//h2")).Text);
        }

        [Test]
        public void AddProduct()
        {
            mainPage = new MainPage(driver);
            mainPage.Login(user);
            ProductService.Add(pie, driver);
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
