using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2022.Pages
{
    public class LoginPage
    {
        public void LoginPageNavigate()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
        }
        
          IWebDriver driver;

          [FindsBy(How = How.XPath, Using = "//div/div/div[1]/div/a")]
          IWebElement signInbutton;

          [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[1]/input")]
          IWebElement emailTextBox;

          [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[2]/input")]
          IWebElement passwordTextBox;
 
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.initElements(driver, this);
        }

        public LoginPage()
        {

        }

        public void signin()
        {
            emailTextBox.SendKeys("gaganbains18@gmail.com");
            passwordTextBox.SendKeys("Gaganpreet1818");
            signInbutton.Click();
        }
    }

}


