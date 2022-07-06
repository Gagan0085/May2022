using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace May2022
{
    [TestClass]
    public class Pagelogin
    {
        public void VerfiyPageLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            LoginP login = new LoginP(driver);
            login.TypeUsername();
            login.TypePassword();
            login.ClickOnLoginButton();
            Thread.Sleep(1000);
            driver.Quit();
            
        }
    }
}
