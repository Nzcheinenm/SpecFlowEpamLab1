using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WebDriverEpamLab2
{
    class AddProdPage
    {

        IWebDriver driver;
        public AddProdPage(IWebDriver driver)
        {
            
            PageFactory.InitElements(driver, this);
        }

       
        [FindsBy(How = How.XPath, Using = ".//a[text()='Create new']")]
        public IWebElement createNewProdBut { get; set; }


        [FindsBy(How = How.XPath, Using = ".//input[@name='ProductName']")]
        public IWebElement inName { get; set; }


        [FindsBy(How = How.XPath, Using = ".//select[@name='CategoryId']/option[2]")]
        public IWebElement inCategoryPick { get; set; }


        [FindsBy(How = How.XPath, Using = ".//select[@name='SupplierId']/option[@value=1]")]
        public IWebElement inSupplierPick { get; set; }


        [FindsBy(How = How.XPath, Using = ".//input[@name='UnitPrice']")]
        public IWebElement inUnitPrice { get; set; }


        [FindsBy(How = How.XPath, Using = ".//input[@name='QuantityPerUnit']")]
        public IWebElement inQuantity { get; set; }


        [FindsBy(How = How.XPath, Using = ".//input[@name='UnitsInStock']")]
        public IWebElement inUnitInStock { get; set; }


        [FindsBy(How = How.XPath, Using = ".//input[@name='UnitsOnOrder']")]
        public IWebElement inUnitsOnOrder { get; set; }


        [FindsBy(How = How.XPath, Using = ".//input[@name='ReorderLevel']")]
        public IWebElement inReorderLevel { get; set; }


        [FindsBy(How = How.XPath, Using = ".//input[@name='Discontinued']")]
        public IWebElement checkDiscont { get; set; }


        [FindsBy(How = How.XPath, Using = ".//input[@type='submit']")]
        public IWebElement buttonSubmit { get; set; }


        public string inNameVal = "1One";
        public string unitPriceVal = "10000";
        public string inQuantityVal = "100";
        public string inUnitInStockVal = "10";
        public string inUnitsOnOrderVal = "10";
        public string inReorderLevelVal = "1";

        public void clickCreateNew()
        {
            createNewProdBut.Click();
        }
        public void addProduct()
        {
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
        }
    }
}
