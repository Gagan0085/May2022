using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2022
{
     public class LoginP
    {
        IWebDriver driver;
        By Username = By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input");
        By Password = By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input");
        By loginButton = By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button");

        public LoginP(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void TypeUsername()
        {
            driver.FindElement(Username).SendKeys("gaganbains18@gmail.com");
        }
        public void TypePassword()
        {
            driver.FindElement(Password).SendKeys("Gaganpreet1818");
        }
        public void ClickOnLoginButton()
        {
            driver.FindElement(loginButton).Click();
        }
    }
}
