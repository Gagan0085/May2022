using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2022.Utilities
{
    internal class wait
    {
        public void WaitForWebElement(IWebDriver driver, String locator,string locatorvalue,int seconds)
        {
            var wait = new WebDriverWait(driver, new TimeSpan(0, 0, 2));
            wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("")));
        }
    }
}
