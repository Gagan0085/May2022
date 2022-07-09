using May2022.Pages;
using May2022.profile_pages;
using May2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace May2022
{
    [Binding]
    public class LanguageStepDefinitions : CommonDriver
    {
        [Given(@"I logged in to localhost  sucessfully")]
        public void GivenILoggedInToLocalhostSucessfully()
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

        [When(@"I create a New language Record")]
        public void WhenICreateANewLanguageRecord()
        {
            ManageLanguage manageLanguageobj = new ManageLanguage(driver);
            manageLanguageobj.addLanguage(driver);
        }

        [Then(@"New language record should be created successfully")]
        public void ThenNewLanguageRecordShouldBeCreatedSuccessfully()
        {
            ManageLanguage manageLanguageobj = new ManageLanguage(driver);
            Assert.IsTrue(manageLanguageobj.addLanguage(driver).Contains("English"));
        }

        [Then(@"Close the Browser")] 
        public void ThenCloseTheBrowser()
        {
            driver.Quit();
        }

        [When(@"I edit a New language Record")]
        public void WhenIEditANewLanguageRecord()
        {
            ManageLanguage manageLanguageobj = new ManageLanguage(driver);
            manageLanguageobj.editLanguage(driver);
        }

        [Then(@"New edited language record should be edited successfully")]
        public void ThenNewEditedLanguageRecordShouldBeEditedSuccessfully()
        {
            ManageLanguage manageLanguageobj = new ManageLanguage(driver);
            Assert.IsTrue(manageLanguageobj.editLanguage(driver).Contains("EditedLanguage"));
        }

        [When(@"I delete a New language Record")]
        public void WhenIDeleteANewLanguageRecord()
        {
            ManageLanguage manageLanguageobj = new ManageLanguage(driver);
            manageLanguageobj.deleteLanguage(driver);
        }

        [Then(@"New editedlanguage record should be deleted successfully")]
        public void ThenNewEditedlanguageRecordShouldBeDeletedSuccessfully()
        {
            
        }
    }
}
