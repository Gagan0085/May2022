using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2022.Pages
{
    internal class LoginPage
    {
        public void loginSteps(IWebDriver driver)
        {

         // Launch Mars logo page
         driver.Navigate().GoToUrl("http://localhost:5000/");

         //Click Sign In
         IWebElement SignIn = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
         SignIn.Click();


         // Identify Username textbox and enter valid email
         IWebElement emailTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
         emailTextbox.SendKeys("gaganbains18@gmail.com");

         // Identify password textbox and enter valid password
         IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
         passwordTextbox.SendKeys("Gaganpreet1818");

         // Click on loginn button
         IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
         loginButton.Click();

        } 
    }
}
