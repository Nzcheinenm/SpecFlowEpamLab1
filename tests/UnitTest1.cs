using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using System;
using System.Threading;
using WebDriverEpamLab2;
using WebDriverEpamLab2.business_object;

namespace WebDriverEpamLab1
{
    public class Tests
    {
        private IWebDriver driver;

        private LoginPage pageOne;
        private AddProdPage pageTwo;
        private CheckProductPage pageThree;
        private LogOutPage pageFour;

        private Login login = new Login("user", "user");

        private Product product = new Product("1One", "10000", "100", "10", "10", "1");
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
            pageOne.loginIn(login.userLog, login.userPass);
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
            Assert.AreEqual(pageThree.inNameText, product.inNameVal);
            Assert.AreEqual(pageThree.inUnitPriceText, "10000,0000");
            Assert.AreEqual(pageThree.inQuantityText, product.inQuantityVal);
            Assert.AreEqual(pageThree.inUnitInStockText, product.inUnitInStockVal);
            Assert.AreEqual(pageThree.inUnitsOnOrderText, product.inUnitsOnOrderVal);
            Assert.AreEqual(pageThree.inReorderLevelText, product.inReorderLevelVal);
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