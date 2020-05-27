using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using TestSeleniumBasic.Business_object;

namespace TestSeleniumBasic
{
    class AllProductsPage
    {
        private IWebDriver driver;
        public AllProductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    
        private IWebElement searchAllProducts => driver.FindElement(By.XPath("(//a[contains(text(),'All Products')])[2]"));
        private IWebElement searchCreateNew => driver.FindElement(By.LinkText("Create new"));
        private IWebElement searchProductName => driver.FindElement(By.XPath("//input[@id=\"ProductName\"]"));
        private IWebElement searchCategoryId => driver.FindElement(By.XPath("//select[@id=\"CategoryId\"]"));
        private IWebElement searchSupplierId => driver.FindElement(By.XPath("//select[@id=\"SupplierId\"]"));
        private IWebElement searchUnitPrice => driver.FindElement(By.XPath("//input[@id=\"UnitPrice\"]"));
        private IWebElement searchQuantityPerUnit => driver.FindElement(By.XPath("//input[@id=\"QuantityPerUnit\"]"));
        private IWebElement searchUnitsInStock => driver.FindElement(By.XPath("//input[@id=\"UnitsInStock\"]"));
        private IWebElement searchUnitsOnOrder => driver.FindElement(By.XPath("//input[@id=\"UnitsOnOrder\"]"));
        private IWebElement searchReorderLevel => driver.FindElement(By.XPath("//input[@id=\"ReorderLevel\"]"));
        private IWebElement searchBatten => driver.FindElement(By.CssSelector(".btn"));
        private IWebElement searchPie => driver.FindElement(By.XPath("//*[text()=\"Pie\"]"));

        public void GiveName(Product Name)

        {
            searchAllProducts.Click(); 
            searchCreateNew.Click();
            new Actions(driver).Click(searchProductName).SendKeys(Name.SearchName).Build().Perform();
        }
        public void GiveCategory(Product Category)
        {
            new Actions(driver).Click(searchCategoryId).SendKeys(Category.SearchCategory).Build().Perform();
        }
        public void GiveSupplier(Product Supplier)
        {
            new Actions(driver).Click(searchSupplierId).SendKeys(Supplier.SearchSupplier).Build().Perform();
        }
        public void GiveUnitPrice(Product UnitPrice)
        {
            new Actions(driver).Click(searchUnitPrice).SendKeys(UnitPrice.SearchUnitPrice).Build().Perform();
        }
        public void GiveQuantityPerUnit(Product QuantityPerUnit)
        {
            new Actions(driver).Click(searchQuantityPerUnit).SendKeys(QuantityPerUnit.SearchQuantityPerUnit).Build().Perform();
        }
        public void GiveUnitsInStock(Product UnitsInStock)
        {
            new Actions(driver).Click(searchUnitsInStock).SendKeys(UnitsInStock.SearchUnitsInStock).Build().Perform();
        }
        public void GiveUnitsOnOrder(Product UnitsOnOrder)
        {
            new Actions(driver).Click(searchUnitsOnOrder).SendKeys(UnitsOnOrder.SearchUnitsOnOrder).Build().Perform();
        }
        public void GiveReorderLevel(Product ReorderLevel)
        {
            new Actions(driver).Click(searchReorderLevel).SendKeys(ReorderLevel.SearchReorderLevel).Build().Perform();
            searchBatten.Click();
        }
    }
}
