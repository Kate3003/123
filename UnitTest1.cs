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
        private MainPage mainPage;
        private const string SearchText = "user";
        private AllProductsPage allProductsPage;
        private const string SearchName = "Pie";
        private const string SearchCategory = "Confections";
        private const string SearchSupplier = "Pavlova, Ltd.";
        private const string SearchUnitPrice = "12";
        private const string SearchQuantityPerUnit = "31-450 g boxes";
        private const string SearchUnitsInStock = "28";
        private const string SearchUnitsOnOrder = "0";
        private const string SearchReorderLevel = "11";
        
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
            mainPage.Login(SearchText);
            Assert.AreEqual("Home page", driver.FindElement(By.XPath("//h2")).Text);
        }

        [Test]
        public void Logout()
        {
            mainPage = new MainPage(driver);
            mainPage.Login(SearchText);
            driver.FindElement(By.XPath("//a[contains(text(),'Logout')]")).Click();
            Assert.AreEqual("Login", driver.FindElement(By.XPath("//h2")).Text);
        }

        [Test]
        public void AddProduct()
        {

            mainPage = new MainPage(driver);
            mainPage.Login(SearchText);
            allProductsPage = new AllProductsPage(driver);
            allProductsPage.GiveName(SearchName);
            allProductsPage.GiveCategory(SearchCategory);
            allProductsPage.GiveSupplier(SearchSupplier);
            allProductsPage.GiveUnitPrice(SearchUnitPrice);
            allProductsPage.GiveQuantityPerUnit(SearchQuantityPerUnit);
            allProductsPage.GiveUnitsInStock(SearchUnitsInStock);
            allProductsPage.GiveUnitsOnOrder(SearchUnitsOnOrder);
            allProductsPage.GiveReorderLevel(SearchReorderLevel);
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
