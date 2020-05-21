using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace WebDriverEpamLab1
{
    public class Tests
    {
        private IWebDriver driver;
        WebDriverWait wait;

        string inNameVal = "1One";
        string unitPriceVal = "10000";
        string inQuantityVal = "100";
        string inUnitInStockVal = "10";
        string inUnitsOnOrderVal = "10";
        string inReorderLevelVal = "1";

        public Boolean isElementPresent(IWebElement webelement)
        {
            try
            {
                return webelement.Displayed;
            }
            catch (Exception)
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
            IWebElement login = driver.FindElement(By.XPath(".//input[@name='Name']"));
            IWebElement password = driver.FindElement(By.XPath(".//input[@name='Password']"));
            IWebElement okButton = driver.FindElement(By.XPath(".//input[@type='submit']"));
            login.SendKeys("user");
            password.SendKeys("user");
            okButton.Click();
            Assert.IsFalse(isElementPresent(login));
        }

        [Test]
        public void Test2AddProduct()
        {
            IWebElement allProductsLink = driver.FindElement(By.XPath(".//a[text()='All Products']"));
            allProductsLink.Click();
            IWebElement createNewProdBut = driver.FindElement(By.XPath(".//a[text()='Create new']"));
            createNewProdBut.Click();

            IWebElement inName = driver.FindElement(By.XPath(".//input[@name='ProductName']"));
            IWebElement inCategoryPick = driver.FindElement(By.XPath(".//select[@name='CategoryId']/option[2]"));
            IWebElement inSupplierPick = driver.FindElement(By.XPath(".//select[@name='SupplierId']/option[@value=1]"));
            IWebElement inUnitPrice = driver.FindElement(By.XPath(".//input[@name='UnitPrice']"));
            IWebElement inQuantity = driver.FindElement(By.XPath(".//input[@name='QuantityPerUnit']"));
            IWebElement inUnitInStock = driver.FindElement(By.XPath(".//input[@name='UnitsInStock']"));
            IWebElement inUnitsOnOrder = driver.FindElement(By.XPath(".//input[@name='UnitsOnOrder']"));
            IWebElement inReorderLevel = driver.FindElement(By.XPath(".//input[@name='ReorderLevel']"));
            IWebElement checkDiscont = driver.FindElement(By.XPath(".//input[@name='Discontinued']"));
            IWebElement buttonSubmit = driver.FindElement(By.XPath(".//input[@type='submit']"));

            inName.SendKeys(inNameVal);
            inCategoryPick.Click();
            inSupplierPick.Click();
            inUnitPrice.SendKeys(unitPriceVal);
            inQuantity.SendKeys(inQuantityVal);
            inUnitInStock.SendKeys(inUnitInStockVal);
            inUnitsOnOrder.SendKeys(inUnitsOnOrderVal);
            inReorderLevel.SendKeys(inReorderLevelVal);
            checkDiscont.Click();

            buttonSubmit.Click();

            Thread.Sleep(2000);
            Assert.IsFalse(isElementPresent(inCategoryPick));
        }



        [Test]
        [Obsolete]
        public void Test3CheckProduct()
        {
            IWebElement allProductsLink = driver.FindElement(By.XPath(".//a[text()='All Products']"));
            allProductsLink.Click();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Timeout = TimeSpan.FromSeconds(8);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));


            IWebElement inName = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//td/a[text()='" + inNameVal + "']")));
            IWebElement inUnitPrice = driver.FindElement(By.XPath(".//td/a[text()='" + inNameVal + "']/following::td[4]"));
            IWebElement inQuantity = driver.FindElement(By.XPath(".//td/a[text()='" + inNameVal + "']/following::td[3]"));
            IWebElement inUnitInStock = driver.FindElement(By.XPath(".//td/a[text()='" + inNameVal + "']/following::td[5]"));
            IWebElement inUnitsOnOrder = driver.FindElement(By.XPath(".//td/a[text()='" + inNameVal + "']/following::td[6]"));
            IWebElement inReorderLevel = driver.FindElement(By.XPath(".//td/a[text()='" + inNameVal + "']/following::td[7]"));
            IWebElement checkDiscont = driver.FindElement(By.XPath(".//td/a[text()='" + inNameVal + "']/following::td[8]"));

            Assert.AreEqual(inName.Text, inNameVal);
            Assert.AreEqual(inUnitPrice.Text, "10000,0000");
            Assert.AreEqual(inQuantity.Text, inQuantityVal);
            Assert.AreEqual(inUnitInStock.Text, inUnitInStockVal);
            Assert.AreEqual(inUnitsOnOrder.Text, inUnitsOnOrderVal);
            Assert.AreEqual(inReorderLevel.Text, inReorderLevelVal);
            Assert.AreEqual(checkDiscont.Text, "True");

        }


        [Test]
        public void Test4Logout()
        {
            IWebElement linkLogout = driver.FindElement(By.XPath(".//a[text()='Logout']"));
            linkLogout.Click();
            Assert.IsFalse(isElementPresent(linkLogout));
        }


        [OneTimeTearDown]
        public void AfterTestSuit()
        {
            driver.Close();
            driver.Quit();
        }

    }
}