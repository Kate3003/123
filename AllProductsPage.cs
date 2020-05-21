using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestSeleniumBasic
{
    class AllProductsPage
    {
        private IWebDriver driver;
        public AllProductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
    
        private IWebElement searchAll => driver.FindElement(By.XPath("(//a[contains(text(),'All Products')])[2]"));
        private IWebElement searchNew => driver.FindElement(By.LinkText("Create new"));
        private IWebElement searchMame => driver.FindElement(By.XPath("//input[@id=\"ProductName\"]"));
        private IWebElement searchCatId => driver.FindElement(By.XPath("//select[@id=\"CategoryId\"]"));
        private IWebElement searchSupId => driver.FindElement(By.XPath("//select[@id=\"SupplierId\"]"));
        private IWebElement searchUP => driver.FindElement(By.XPath("//input[@id=\"UnitPrice\"]"));
        private IWebElement searchQPU => driver.FindElement(By.XPath("//input[@id=\"QuantityPerUnit\"]"));
        private IWebElement searchUIS => driver.FindElement(By.XPath("//input[@id=\"UnitsInStock\"]"));
        private IWebElement searchUOO => driver.FindElement(By.XPath("//input[@id=\"UnitsOnOrder\"]"));
        private IWebElement searchRL => driver.FindElement(By.XPath("//input[@id=\"ReorderLevel\"]"));
        private IWebElement searchBTN => driver.FindElement(By.CssSelector(".btn"));

        public void SearchForHost1(string Pie)

        {
            searchAll.Click();
            searchNew.Click();
            searchMame.SendKeys(Pie);
        }
        public void SearchCatId(string Confections)
        {
            searchCatId.SendKeys(Confections);
        }
        public void SearchSupId(string Pavlova)
        {
            searchSupId.SendKeys("Pavlova, Ltd.");
        }
        public void SearchUP(string UP)
        {
            searchUP.SendKeys("12");
        }
        public void SearchQPU(string QRU)
        {
            searchQPU.SendKeys("31-450 g boxes");
        }
        public void SearchUIS(string UIS)
        {
            searchUIS.SendKeys("28");
        }
        public void SearchUOO(string UOO)
        {
            searchUOO.SendKeys("0");
        }
        public void SearchRL(string RL)
        {
            searchRL.SendKeys("11");
            searchBTN.Click();
        }
    }
}
