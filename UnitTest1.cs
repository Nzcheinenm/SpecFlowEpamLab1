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
        WebDriverWait wait;

        LoginPage pageOne;
        AddProdPage pageTwo;
        CheckProductPage pageThree;
        LogOutPage pageFour;

        string userLog = "user";
        string userPass = "user";

        public Boolean isElementPresent(IWebElement webelement)
        {
            try
            {
                return webelement.Displayed;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }

        }


        [OneTimeSetUp]
        public void BeforeTestSuit()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
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
            Assert.IsFalse(isElementPresent(pageTwo.inCategoryPick));
        }

        [Test]
        public void Test3CheckProduct()
        {
            pageTwo = new AddProdPage(driver);
            pageThree = new CheckProductPage(driver);
            pageThree.clickAllProd();
            Assert.AreEqual(pageThree.inName.Text, pageTwo.inNameVal);
            Assert.AreEqual(pageThree.inUnitPrice.Text, "10000,0000");
            Assert.AreEqual(pageThree.inQuantity.Text, pageTwo.inQuantityVal);
            Assert.AreEqual(pageThree.inUnitInStock.Text, pageTwo.inUnitInStockVal);
            Assert.AreEqual(pageThree.inUnitsOnOrder.Text, pageTwo.inUnitsOnOrderVal);
            Assert.AreEqual(pageThree.inReorderLevel.Text, pageTwo.inReorderLevelVal);
            Assert.AreEqual(pageThree.checkDiscont.Text, "True");

        }


        [Test]
        public void Test4Logout()
        {
            pageFour = new LogOutPage(driver);
            pageFour.logOut();
            Assert.IsFalse(isElementPresent(pageFour.linkLogout));
        }


        [OneTimeTearDown]
        public void AfterTestSuit()
        {
            driver.Close();
            driver.Quit();
        }

    }
}