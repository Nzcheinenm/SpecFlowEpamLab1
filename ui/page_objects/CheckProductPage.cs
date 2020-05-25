using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using WebDriverEpamLab2.business_object;

namespace WebDriverEpamLab2
{
    class CheckProductPage
    {

        private IWebDriver driver;
        private IWebElement element;
        private WebDriverWait wait;
        
        public CheckProductPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }

        private static Product product;
        

        public void clickAllProd()
        {
            driver.FindElement(By.XPath(".//a[text()='All Products']")).Click();

        }

        public Product getTextElement(Product getElementProd)
        {
            Product prod = new Product();
            prod.inNameVal = driver.FindElement(By.XPath(".//td/a[text()='" + getElementProd.inNameVal + "']")).Text;
            prod.unitPriceVal = driver.FindElement(By.XPath(".//td/a[text()='" + getElementProd.inNameVal + "']/following::td[4]")).Text;
            prod.inQuantityVal = driver.FindElement(By.XPath(".//td/a[text()='" + getElementProd.inNameVal + "']/following::td[3]")).Text;
            prod.inUnitInStockVal = driver.FindElement(By.XPath(".//td/a[text()='" + getElementProd.inNameVal + "']/following::td[5]")).Text;
            prod.inUnitsOnOrderVal = driver.FindElement(By.XPath(".//td/a[text()='" + getElementProd.inNameVal + "']/following::td[6]")).Text;
            prod.inReorderLevelVal = driver.FindElement(By.XPath(".//td/a[text()='" + getElementProd.inNameVal + "']/following::td[7]")).Text;
            return prod;
        }

    }
}
