using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection.Metadata;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;

namespace WebDriverEpamLab2
{
    class LoginPage
    {
        IWebDriver driver;
        ActionElements action;

        public LoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            action = new ActionElements(driver);
        }

        [FindsBy(How = How.XPath, Using = ".//input[@name='Name']")]
        public IWebElement login { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@name='Password']")]
        public IWebElement password { get; set; }

        [FindsBy(How = How.XPath, Using = ".//input[@type='submit']")]
        public IWebElement okButton { get; set; }

        [FindsBy(How = How.XPath, Using = ".//a[text()='All Products']")]
        public IWebElement allProductsLink { get; set; }

        public void loginIn(string userLog, string userPass)
        {
            action.sendElement(login,userLog);
            action.sendElement(password,userPass);
            action.clickElement(okButton);
            action.clickElement(allProductsLink);
        }
    }
}
