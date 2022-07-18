using May2022.Pages;
using May2022.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace May2022.Tests
{
    [TestFixture]
    public class Logo : CommonDriver
    {

        [SetUp]
        public void LoginFunction()
        {

            // Open chrome Browser
            driver = new ChromeDriver();
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