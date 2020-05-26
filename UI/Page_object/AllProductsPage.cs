using OpenQA.Selenium;
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

        public void GiveName(Product Name)

        {
            searchAllProducts.Click();
            searchCreateNew.Click();
            searchProductName.SendKeys("Pie");
        }
        public void GiveCategory(Product Category)
        {
            searchCategoryId.SendKeys("Confections");
        }
        public void GiveSupplier(Product Supplier)
        {
            searchSupplierId.SendKeys("Pavlova, Ltd.");
        }
        public void GiveUnitPrice(Product UnitPrice)
        {
            searchUnitPrice.SendKeys("12");
        }
        public void GiveQuantityPerUnit(Product QuantityPerUnit)
        {
            searchQuantityPerUnit.SendKeys("31-450 g boxes");
        }
        public void GiveUnitsInStock(Product UnitsInStock)
        {
            searchUnitsInStock.SendKeys("28");
        }
        public void GiveUnitsOnOrder(Product UnitsOnOrder)
        {
            searchUnitsOnOrder.SendKeys("0");
        }
        public void GiveReorderLevel(Product ReorderLevel)
        {
            searchReorderLevel.SendKeys("11");
            searchBatten.Click();
        }
    }
}
