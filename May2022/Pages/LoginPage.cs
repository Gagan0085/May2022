﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace May2022.Pages
{
    public class LoginPage
    {
        public IWebDriver driver;
        [FindsBy(How = How.XPath, Using = "//div/div/div[1]/div/a")]
        public IWebElement SignInbtn { get; set; }
        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement Emailtxtbox { get; set; }
        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement PasswordtxtBox { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        public IWebElement LoginBtn { get; set; }
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void addlogindetail(IWebDriver driver)
        {
            //driver.Navigate().GoToUrl("http://localhost:5000/");
            //Thread.Sleep(2000);
            //driver.Manage().Window.Maximize();
            //Thread.Sleep(2000);
            //SignInbtn.Click();
            //Thread.Sleep(2000);
            Emailtxtbox.Click();
            Emailtxtbox.Clear();
            Thread.Sleep(1000);
            Emailtxtbox.SendKeys("gaganbains18@gmail.com");
            Thread.Sleep(1000);
            PasswordtxtBox.Click();
            PasswordtxtBox.SendKeys("Gaganpreet1818");
            Thread.Sleep(1000);
            //LoginBtn.Click();
            //Thread.Sleep(5000);
        }
        public void login(IWebDriver driver)
        {
            LoginBtn.Click();
            Thread.Sleep(2000);
        }

    }

}




