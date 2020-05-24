using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection.Metadata;
using SeleniumExtras.PageObjects;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace WebDriverEpamLab2
{
    class LogOutPage
    {
        private IWebDriver driver;
        public LogOutPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = ".//a[text()='Logout']")]
        private IWebElement linkLogout { get; set; }
        
        public void logOut()
        {
            linkLogout.Click();
        }

        public Boolean isPresent()
        {
            IsPresentElement isPresent = new IsPresentElement();
            return isPresent.isElementPresent(linkLogout);
        }
    }
}
