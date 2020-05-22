using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using System;
using System.Threading;
using WebDriverEpamLab2;

namespace WebDriverEpamLab1
{
    public class Tests
    {
        private IWebDriver driver;

        private LoginPage pageOne;
        private AddProdPage pageTwo;
        private CheckProductPage pageThree;
        private LogOutPage pageFour;

        private const string userLog = "user";
        private const string userPass = "user";

        private const string inNameVal = "1One";
        private const string inQuantityVal = "100";
        private const string inUnitInStockVal = "10";
        private const string inUnitsOnOrderVal = "10";
        private const string inReorderLevelVal = "1";

        


        [OneTimeSetUp]
        public void BeforeTestSuit()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1Login()
        {
            pageOne = new LoginPage(driver);          
            pageOne.loginIn(userLog,userPass);
        }

        [Test]
        public void Test2AddProduct()
        {
            pageTwo = new AddProdPage(driver);
            pageTwo.clickCreateNew();
            pageTwo.addProduct();
            Assert.IsFalse(pageTwo.isPresent());
        }

        [Test]
        public void Test3CheckProduct()
        {
            pageThree = new CheckProductPage(driver);
            pageThree.clickAllProd();
            pageThree.getTextElement();
            Assert.AreEqual(pageThree.inNameText,inNameVal);
            Assert.AreEqual(pageThree.inUnitPriceText, "10000,0000");
            Assert.AreEqual(pageThree.inQuantityText,inQuantityVal);
            Assert.AreEqual(pageThree.inUnitInStockText,inUnitInStockVal);
            Assert.AreEqual(pageThree.inUnitsOnOrderText,inUnitsOnOrderVal);
            Assert.AreEqual(pageThree.inReorderLevelText,inReorderLevelVal);
            Assert.AreEqual(pageThree.checkDiscontText, "True");

        }


        [Test]
        public void Test4Logout()
        {
            pageFour = new LogOutPage(driver);
            pageFour.logOut();
            Assert.IsFalse(pageFour.isPresent());
        }


        [OneTimeTearDown]
        public void AfterTestSuit()
        {
            driver.Close();
            driver.Quit();
        }

    }
}