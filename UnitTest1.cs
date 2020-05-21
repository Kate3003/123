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
        private const string SearchText1 = "Pie";
        private const string SearchText2 = "Confections";
        private const string SearchText3 = "Pavlova, Ltd.";
        private const string SearchText4 = "12";
        private const string SearchText5 = "31-450 g boxes";
        private const string SearchText6 = "28";
        private const string SearchText7 = "0";
        private const string SearchText8 = "11";
        
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
            mainPage.SearchForHost(SearchText);
            Assert.AreEqual("Home page", driver.FindElement(By.XPath("//h2")).Text);
        }

        [Test]
        public void Logout()
        {
            mainPage = new MainPage(driver);
            mainPage.SearchForHost(SearchText);
            driver.FindElement(By.XPath("//a[contains(text(),'Logout')]")).Click();
            Assert.AreEqual("Login", driver.FindElement(By.XPath("//h2")).Text);
        }

        [Test]
        public void AddProduct()
        {
            mainPage = new MainPage(driver);
            mainPage.SearchForHost(SearchText);
            allProductsPage = new AllProductsPage(driver);
            allProductsPage.SearchForHost1(SearchText1);
            allProductsPage.SearchCatId(SearchText2);
            allProductsPage.SearchSupId(SearchText3);
            allProductsPage.SearchUP(SearchText4);
            allProductsPage.SearchQPU(SearchText5);
            allProductsPage.SearchUIS(SearchText6);
            allProductsPage.SearchUOO(SearchText7);
            allProductsPage.SearchRL(SearchText8);
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