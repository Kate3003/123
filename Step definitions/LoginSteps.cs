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
    class LoginSteps
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
    }
}
