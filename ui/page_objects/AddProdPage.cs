using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using WebDriverEpamLab2.business_object;

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
        

        public void clickCreateNew()
        {
            createNewProdBut.Click();
        }
        public void addProduct(Product product)
        {
            inName.SendKeys(product.inNameVal);
            inCategoryPick.Click();
            inSupplierPick.Click();
            inUnitPrice.SendKeys(product.unitPriceVal);
            inQuantity.SendKeys(product.inQuantityVal);
            inUnitInStock.SendKeys(product.inUnitInStockVal);
            inUnitsOnOrder.SendKeys(product.inUnitsOnOrderVal);
            inReorderLevel.SendKeys(product.inReorderLevelVal);
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
