using May2022.profile_pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace May2022
{
    [Binding]
    public class LanguageStepDefinitions
    {
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
            Assert.IsTrue(manageLanguageobj.addLanguage().Contains("English"));
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
        public void ThenNewEditedLanguageRecordShouldBeDeletedSuccessfully()
        {
            ManageLanguage manageLanguageobj = new ManageLanguage(driver);
            Assert.IsTrue(manageLanguageobj.editLanguage().Contains("EditedLanguage"));
        }
        [Then(@"Close the Browser")]
        public void ThenCloseTheBrowser()
        {
            driver.Quit();
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
