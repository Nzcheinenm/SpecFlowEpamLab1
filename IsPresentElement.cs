using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverEpamLab2
{
    class IsPresentElement
    {
        public Boolean isElementPresent(IWebElement webelement)
        {
            try
            {
                return webelement.Displayed;
            }
            catch (NoSuchElementException e)
            {
                return false;
            }

        }
    }
}
