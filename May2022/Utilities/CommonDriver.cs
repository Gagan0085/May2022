using May2022.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2022.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;

        [OneTimeSetUp]
        public void Loginfunction()
        {
            {
                // open chrome browser
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl("http://localhost:5000/");
                driver.Manage().Window.Maximize();

                //Loginpage object initilization and definition
                HomePage HomePageobj = new HomePage(driver);
                HomePageobj.Signin(driver);
                LoginPage Loginpageobj = new LoginPage(driver);
                Loginpageobj.addlogindetail(driver);
                Loginpageobj.login(driver);
            }
        }

    }
}
