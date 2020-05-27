using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using System;
using System.Threading;
using WebDriverEpamLab2;
using WebDriverEpamLab2.business_object;
using WebDriverEpamLab2.service.ui;

namespace WebDriverEpamLab1
{
    public class Tests
    { /*
        private IWebDriver driver;

        private LoginPage pageLogin;
        private AddProdPage pageAddProduct;
        private CheckProductPage pageCheckProduct;
        private LogOutPage pageLogOut;

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
            pageLogin = new LoginPage(driver);          
            pageLogin.loginIn(login);
        }

        [Test]
        public void Test2AddProduct()
        {
            pageAddProduct = new AddProdPage(driver);
            pageAddProduct.clickCreateNew();
            pageAddProduct.addProduct(product);
            Assert.IsFalse(pageAddProduct.isPresent());
        }

        [Test]
        public void Test3CheckProduct()
        {
            pageCheckProduct = new CheckProductPage(driver);
            pageCheckProduct.clickAllProd();
            Product prod = pageCheckProduct.getTextElement(product);
            Assert.AreEqual(prod.inNameVal, product.inNameVal);
            Assert.AreEqual(prod.inQuantityVal, product.inQuantityVal);
            Assert.AreEqual(prod.inUnitInStockVal, product.inUnitInStockVal);
            Assert.AreEqual(prod.inUnitsOnOrderVal, product.inUnitsOnOrderVal);
            Assert.AreEqual(prod.inReorderLevelVal, product.inReorderLevelVal);
        }

        [Test]
        public void Test4Logout()
        {
            pageLogOut = new LogOutPage(driver);
            pageLogOut.logOut();
            Assert.IsFalse(pageLogOut.isPresent());
        }


        [Test]
        public void Test5Service()
        {
            LogAndCheckService service = new LogAndCheckService();
            Product productTest = service.LoginAndCheckProduct(login,product,driver);
            Assert.IsTrue(product.inNameVal == productTest.inNameVal);
        }

        [OneTimeTearDown]
        public void AfterTestSuit()
        {
            driver.Close();
            driver.Quit();
        } */
    } 
}