using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using WebDriverEpamLab2.business_object;

namespace WebDriverEpamLab2.service.ui
{
    class LogAndCheckService
    {
        private IWebDriver driver;

        private LoginPage pageOne;
        private CheckProductPage pageTwo;

        public Product LoginAndCheckProduct (Login login, Product product, IWebDriver driver)
        {
            LoginPage loginPage = new LoginPage(driver);
            loginPage.loginIn(login);
            CheckProductPage checkProduct = new CheckProductPage(driver);
            checkProduct.clickAllProd();
            Product prod = checkProduct.getTextElement(product);
            return prod;
        }
    }
}
