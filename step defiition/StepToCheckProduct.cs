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
        Product prod;


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

        [When(@"click to checkProduct allProduct")]
        public void WhenToClickAllProduct ()
        {
            new CheckProductPage(driver).clickAllProd();
        }

        [When(@"check to product info ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)""")]
        public void WhenCheckProduct (string name,string unPrice,string inQual, string inUnitSt,string inUnitOrder,string inReord)
        {
            CheckProductPage check = new CheckProductPage(driver);
            prod = check.getTextElement(new business_object.Product(name, unPrice, inQual, inUnitSt, inUnitOrder, inReord));
        }

        [Then(@"name product should be name,inQuality and inUnitStock- ""(.*)"", ""(.*)"", ""(.*)""")]
        public void ThenCheckProductName (string name, string inQual, string inUnit)
        {
            Assert.AreEqual(prod.inNameVal, name);
            Assert.AreEqual(prod.inUnitInStockVal, inUnit);
            Assert.AreEqual(prod.inQuantityVal, inQual);
            driver.Close();
        }
    }
}
