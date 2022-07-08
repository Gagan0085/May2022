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
            public void SignInfunction()
            {
                // open chrome browser
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                //LoginPage object initilization and definition
                LoginPage LoginPageobj = new LoginPage(driver);
                LoginPageobj.addlogindetail(driver);
            }
            [OneTimeTearDown]
            public void CloseTestRun()
            {
                driver.Quit();
            }
     }
 }


