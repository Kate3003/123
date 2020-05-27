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
        private Product pie = new Product("Pie", "Confections", "Pavlova, Ltd.", "12", "31-450 g boxes", "28", "0", "11");
        private User user = new User("user");
        private AllProductsPage allProductsPage;
        private const string searchPie = "Pie";
        private const string searchHomePage = "Home page";
        private const string searchLogin = "Login";

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
            Assert.IsTrue(searchHomePage == "Home page");
        }

        [Test]
        public void Logout()
        {
            mainPage = new MainPage(driver);
            mainPage.Login(user);
            mainPage.Logout(user);
            Assert.IsTrue(searchLogin == "Login");
        }

        [Test]
        public void AddProduct()
        {
            mainPage = new MainPage(driver);
            mainPage.Login(user);
            allProductsPage = new AllProductsPage(driver);
            ProductService.Add(pie, driver);
            Assert.IsTrue(searchPie == "Pie");
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
