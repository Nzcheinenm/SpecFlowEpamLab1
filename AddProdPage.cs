using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WebDriverEpamLab2
{
    class AddProdPage
    {

        private IWebDriver driver;
        private WebDriverWait wait;
        public AddProdPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        
        [FindsBy(How = How.XPath, Using = ".//a[text()='Create new']")]
        private IWebElement createNewProdBut { get; set; }


        [FindsBy(How = How.XPath, Using = ".//input[@name='ProductName']")]
        private IWebElement inName { get; set; }


        [FindsBy(How = How.XPath, Using = ".//select[@name='CategoryId']/option[2]")]
        private IWebElement inCategoryPick { get; set; }


        [FindsBy(How = How.XPath, Using = ".//select[@name='SupplierId']/option[@value=1]")]
        private IWebElement inSupplierPick { get; set; }


        [FindsBy(How = How.XPath, Using = ".//input[@name='UnitPrice']")]
        private IWebElement inUnitPrice { get; set; }


        [FindsBy(How = How.XPath, Using = ".//input[@name='QuantityPerUnit']")]
        private IWebElement inQuantity { get; set; }


        [FindsBy(How = How.XPath, Using = ".//input[@name='UnitsInStock']")]
        private IWebElement inUnitInStock { get; set; }


        [FindsBy(How = How.XPath, Using = ".//input[@name='UnitsOnOrder']")]
        private IWebElement inUnitsOnOrder { get; set; }


        [FindsBy(How = How.XPath, Using = ".//input[@name='ReorderLevel']")]
        private IWebElement inReorderLevel { get; set; }


        [FindsBy(How = How.XPath, Using = ".//input[@name='Discontinued']")]
        private IWebElement checkDiscont { get; set; }


        [FindsBy(How = How.XPath, Using = ".//input[@type='submit']")]
        private IWebElement buttonSubmit { get; set; }


        private string inNameVal = "1One";
        private string unitPriceVal = "10000";
        private string inQuantityVal = "100";
        private string inUnitInStockVal = "10";
        private string inUnitsOnOrderVal = "10";
        private string inReorderLevelVal = "1";

        public void clickCreateNew()
        {
            createNewProdBut.Click();
        }
        public void addProduct()
        {
            
            wait.Timeout = TimeSpan.FromSeconds(20);
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

        }

        public Boolean isPresent()
        {
            IsPresentElement isPresent = new IsPresentElement();
            return isPresent.isElementPresent(inCategoryPick);
        }
    }
}
