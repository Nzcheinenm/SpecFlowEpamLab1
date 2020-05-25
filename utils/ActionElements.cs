using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverEpamLab2
{
    class ActionElements
    {
        IWebDriver driver;

        public ActionElements(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void clickElement(IWebElement element)
        {
            new Actions(driver).Click().Click(element).Build().Perform();
        }

        public void sendElement(IWebElement element, string text)
        {
            new Actions(driver).SendKeys(element, text)
                .Build().Perform();
        }
    }
}
