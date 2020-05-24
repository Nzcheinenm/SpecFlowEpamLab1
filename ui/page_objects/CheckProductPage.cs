using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace WebDriverEpamLab2
{
    class CheckProductPage
    {

        private IWebDriver driver;
        private WebDriverWait wait;

        public string inNameText;
        public string inUnitPriceText;
        public string inQuantityText;
        public string inUnitInStockText;
        public string inUnitsOnOrderText;
        public string inReorderLevelText;
        public string checkDiscontText;

        
        public CheckProductPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        private const string inNameVal = "1One";


        [FindsBy(How = How.XPath, Using = ".//a[text()='All Products']")]
        private IWebElement allProductsLink { get; set; }


        [FindsBy(How = How.XPath, Using = ".//td/a[text()='" + inNameVal + "']")]
        private IWebElement inName { get; set; }


        [FindsBy(How = How.XPath, Using = ".//td/a[text()='" + inNameVal + "']/following::td[4]")]
        private IWebElement inUnitPrice { get; set; }


        [FindsBy(How = How.XPath, Using = ".//td/a[text()='" + inNameVal + "']/following::td[3]")]
        private IWebElement inQuantity { get; set; }


        [FindsBy(How = How.XPath, Using = ".//td/a[text()='" + inNameVal + "']/following::td[5]")]
        private IWebElement inUnitInStock { get; set; }


        [FindsBy(How = How.XPath, Using = ".//td/a[text()='" + inNameVal + "']/following::td[6]")]
        private IWebElement inUnitsOnOrder { get; set; }


        [FindsBy(How = How.XPath, Using = ".//td/a[text()='" + inNameVal + "']/following::td[7]")]
        private IWebElement inReorderLevel { get; set; }


        [FindsBy(How = How.XPath, Using = ".//td/a[text()='" + inNameVal + "']/following::td[8]")]
        private IWebElement checkDiscont { get; set; }


        public void clickAllProd()
        {
            allProductsLink.Click();
        }

        public void getTextElement()
        {
            inNameText = inName.Text;
            inUnitPriceText = inUnitPrice.Text;
            inQuantityText = inQuantity.Text;
            inUnitInStockText = inUnitInStock.Text;
            inUnitsOnOrderText = inUnitsOnOrder.Text;
            inReorderLevelText = inReorderLevel.Text;
            wait.Timeout = TimeSpan.FromSeconds(50);
            checkDiscontText = checkDiscont.Text;
        }

    }
}
