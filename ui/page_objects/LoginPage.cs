using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection.Metadata;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;
using WebDriverEpamLab2.business_object;

namespace WebDriverEpamLab2
{
    class LoginPage
    {
        private IWebDriver driver;
        private ActionElements action;
        private Login loginBo;

        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            action = new ActionElements(driver);
        }

        [FindsBy(How = How.XPath, Using = ".//input[@name='Name']")]
        private IWebElement login { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='Password']")]
        private IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@type='submit']")]
        private IWebElement okButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='All Products']")]
        private IWebElement allProductsLink { get; set; }

        public void loginIn(string userLog, string userPass)
        {
            action.sendElement(login,userLog);
            action.sendElement(password,userPass);
            action.clickElement(okButton);
            action.clickElement(allProductsLink);
        }
    }
}
