using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using WebDriverEpamLab2.business_object;

namespace WebDriverEpamLab2.step_defiition
{
    [Binding]
    class StepToCheckProduct
    {
        IWebDriver driver;

        [Given(@"Go to url ""(.*)""")] 
        public void GivenGoToUrl(string url)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();
        }

        [When(@"Login to application ""(.*)"",""(.*)""")]
        public void WhenLoginToApplication(string log, string pass)
        {
            new LoginPage(driver).loginIn(new business_object.Login(log, pass));
        }

        [When(@"click to button Create product")]
        public void WhenToClickAddProduct ()
        {
            new AddProdPage(driver).clickCreateNew();
        }

        [When(@"Add to product info ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void WhenAddProduct (string name,string unPrice,string inQual, string inUnitSt,string inUnitOrder,string inReord)
        {
            new AddProdPage(driver).addProduct(new Product(name,unPrice,inQual,inUnitSt,inUnitOrder,inReord));
        }

        [Then(@"check that the window Create Product has closed")]
        public void ThenCheckClosedWindow ()
        {
            Assert.IsFalse(new AddProdPage(driver).isPresent());
            driver.Close();
        }
    }
}
