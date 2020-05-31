using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TestSeleniumBasic.Business_object;

namespace TestSeleniumBasic.Step_definitions
{
    [Binding]
    class NewProduct
    {
        private IWebDriver driver;

        [Given(@"I open ""(.*)"" url")]
        public void GivenIOpenUrl(string url)
        {
            driver = new ChromeDriver();
            driver.Url = url;
        }

        [When(@"I type in the fields Name ""(.*)"", Password ""(.*)""")]
        public void WhenItypeInTheFieldNmae(string name)
        {
            new MainPage(driver).Login(new User(name));
        }

        [When(@"I click the login button")]
        public void WhenIClickTheLoginButton()
        {
            new MainPage(driver).LoginClick();
        }

        [Then(@"The phrase should be ""(.*)""")]
        public void ThenThePhraseShouldBe(string expectedText)
        {
            Assert.AreEqual(expectedText, new MainPage(driver).CheckLogin());
        }

        [When(@"I click the link All Products")]
        public void WhenIClickTheLinkAllProducts()
        {
            new AllProductsPage(driver).AllProducts();
        }

        [When(@"I click the Create new button")]
        public void WhenIClickTheCreateNewButton()
        {
            new AllProductsPage(driver).CreateNew();
        }

        [Then(@"I should be at the ""(.*)"" page")]
        public void ThenProductEditingShouldBe(string ecpectedProductEditing)
        {
            Assert.AreEqual(ecpectedProductEditing, new AllProductsPage(driver).CheckProductEditingPage(new Product(null, null, null, null,
                null, null, null, null, null, ecpectedProductEditing)));
        }

        [When(@"I type the value ""(.*)"" ProductName")]
        public void WhenITypeTheValueProductName(string ProductName)
        {
            new AllProductsPage(driver).GiveName(new Product(ProductName, null, null, null, null, null, null, null, null, null));
        }


        [When(@"I select ""(.*)"" Category")]
        public void WhenISelectCategoryID(string CategoryID)
        {
            new AllProductsPage(driver).GiveCategory(new Product(null, CategoryID, null, null, null, null, null, null, null, null));
        }


        [When(@"I select ""(.*)"" Supplier")]
        public void WhenISelectSupplier(string Supplier)
        {
            new AllProductsPage(driver).GiveSupplier(new Product(null, null, Supplier, null, null, null, null, null, null, null));
        }


        [When(@"I type the value ""(.*)"" UnitPrice")]
        public void WhenITypeTheValueUnitPrice(string UnitPrice)
        {
            new AllProductsPage(driver).GiveUnitPrice(new Product(null, null, null, UnitPrice, null, null, null, null, null, null));
        }


        [When(@"I type the value ""(.*)"" QuantityPerUnit")]
        public void WhenITypeTheValueQuantityPerUnit(string QuantityPerUnit)
        {
            new AllProductsPage(driver).GiveQuantityPerUnit(new Product(null, null, null, null, QuantityPerUnit, null, null, null, null, null));
        }


        [When(@"I type the value ""(.*)"" UnitsInStock")]
        public void WhenITypeTheValueUnitsInStock(string UnitsInStock)
        {
            new AllProductsPage(driver).GiveUnitsInStock(new Product(null, null, null, null, null, UnitsInStock, null, null, null, null));
        }


        [When(@"I type the value ""(.*)"" UnitsOnOrder")]
        public void WhenITypeTheValueUnitsOnOrder(string UnitsOnOrder)
        {
            new AllProductsPage(driver).GiveUnitsOnOrder(new Product(null, null, null, null, null, null, UnitsOnOrder, null, null, null));
        }



        [When(@"I type the value ""(.*)"" ReorderLevel")]
        public void WhenITypeTheValueReorderLevel(string ReorderLevel)
        {
            new AllProductsPage(driver).GiveReorderLevel(new Product(null, null, null, null, null, null, null, ReorderLevel, null, null));
        }


        [When(@"I click the Send button")]
        public void WhenIClickTheSendButton()
        {
            new AllProductsPage(driver).Batten();
        }


        [Then(@"Product Name schould be ""(.*)""")]
        public void ThenProductNameShouldBe(string Pie)
        {
            Assert.AreEqual(Pie, new AllProductsPage(driver).CheckProduct(new Product(null, null, null, null, null, null, null, null, Pie, null)));
        }
    }
}
