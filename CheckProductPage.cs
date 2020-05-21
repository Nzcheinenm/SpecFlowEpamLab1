using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverEpamLab2
{
    class CheckProductPage
    {

        IWebDriver driver;
        public CheckProductPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        private const string inNameVal = "1One";
        

        [FindsBy(How = How.XPath, Using = ".//a[text()='All Products']")]
        public IWebElement allProductsLink { get; set; }


        [FindsBy(How = How.XPath, Using = ".//td/a[text()='" + inNameVal + "']")]
        public IWebElement inName { get; set; }



        [FindsBy(How = How.XPath, Using = ".//td/a[text()='" + inNameVal + "']/following::td[4]")]
        public IWebElement inUnitPrice { get; set; }


        [FindsBy(How = How.XPath, Using = ".//td/a[text()='" + inNameVal + "']/following::td[3]")]
        public IWebElement inQuantity { get; set; }


        [FindsBy(How = How.XPath, Using = ".//td/a[text()='" + inNameVal + "']/following::td[5]")]
        public IWebElement inUnitInStock { get; set; }


        [FindsBy(How = How.XPath, Using = ".//td/a[text()='" + inNameVal + "']/following::td[6]")]
        public IWebElement inUnitsOnOrder { get; set; }


        [FindsBy(How = How.XPath, Using = ".//td/a[text()='" + inNameVal + "']/following::td[7]")]
        public IWebElement inReorderLevel { get; set; }


        [FindsBy(How = How.XPath, Using = ".//td/a[text()='" + inNameVal + "']/following::td[8]")]
        public IWebElement checkDiscont { get; set; }


        public void clickAllProd()
        {
            allProductsLink.Click();
        }
        
    }
}
