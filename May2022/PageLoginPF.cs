using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2022
{
    [TestClass]
    public class PageLoginPF
    {
        [TestMethod]
        public void verifyPageLoginPF()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            LoginPagePF loginPF = new LoginPagePF();
            PageFactory.InitElements(driver, loginPF);
            loginPF.Username.SendKeys("gaganbains18@gmail.com");
            loginPF.Password.SendKeys("Gaganpreet1818");
            loginPF.ClickonLoginbutton();
        }
    }
}
