using May2022.Pages;
using May2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace May2022.Tests
{
    [TestFixture]
    internal class Logo_Tests : CommonDriver
    {
        
        [SetUp]
        public void LoginFunction()
        {

            // Open chrome Browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Login page object initialization and definition
            LoginPage loginPageobj = new LoginPage();
            loginPageobj.loginSteps(driver);

            //Home page object initialization and definition
            HomePage homePageobj = new HomePage();
            homePageobj.GoToProfile(driver);

        }

        [Test]
        public void EditLogo_Test()
        {
            //Profile page object initialization and definition
            ProfilePage profilePageobj = new ProfilePage();
            profilePageobj.addLanguage(driver);

        }

        [TearDown]
        public void CloseTestRun()
        {

        }

    }

}