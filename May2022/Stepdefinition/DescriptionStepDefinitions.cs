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
    public class DescriptionFeature1StepDefinitions : CommonDriver
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
        [When(@"I create a New description Record")]
        public void WhenICreateANewDescriptionRecord()
        {
            Managedescription managedescriptionobj = new Managedescription(driver);
            managedescriptionobj.addDesc(driver);
        }
        [Then(@"New description record should be created successfully")]
        public void ThenNewDescriptionRecordShouldBeCreatedSuccessfully()
        {
            Managedescription managedescriptionobj = new Managedescription(driver);
            Assert.IsTrue(managedescriptionobj.GetDescription().Contains("Hi Good day"));
        }
        [Then(@"Close the Browser")]
        public void ThenCloseTheBrowser()
        {
            driver.Quit();
        }
        [When(@"I edit a New description Record")]
        public void WhenIEditANewDescriptionRecord()
        {
            Managedescription managedescriptionobj = new Managedescription(driver);
            managedescriptionobj.editDesc(driver);
        }
        [Then(@"New edited description record should be deleted successfully")]
        public void ThenNewEditedDescriptionRecordShouldBeDeletedSuccessfully()
        {
            Managedescription managedescriptionobj = new Managedescription(driver);
            Assert.IsTrue(managedescriptionobj.GeteditedDescription().Contains("Edited Description"));
        }
        [When(@"I delete a New description Record")]
        public void WhenIDeleteANewDescriptionRecord()
        {
            Managedescription managedescriptionobj = new Managedescription(driver);
            managedescriptionobj.delDesc(driver);
        }
        [Then(@"New editeddescription record should be deleted successfully")]
        public void ThenNewEditeddescriptionRecordShouldBeDeletedSuccessfully()
        {
            //IWebElement DeleteEntry = driver.FindElement(By.XPath("/html/body/div[1]"));
            //if (DeleteEntry.Text != "")
            //{
            //    Assert.Pass("Seller not able to delete description");
            //}
            //else
            //{
            //    Assert.Fail("Seller is able to delete description");
            //}
        }
    }
}