using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace May2022.Pages
{
    internal class ProfilePage
    {
        public void addLanguage(IWebDriver driver)
        {
            //Click on language button and add language
            IWebElement languageButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languageButton.Click();

            IWebElement addNewButton = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNewButton.Click();

            IWebElement textBox = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            textBox.Click();
            textBox.SendKeys("English");

            IWebElement dropDown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            dropDown.Click();

            IWebElement dropDownSelect = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            dropDownSelect.SendKeys("Basic");
            dropDownSelect.Click();

            IWebElement addBtn = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            addBtn.Click();
            

            //Click on Education button and add Education
            IWebElement educationButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[3]"));
            educationButton.Click();

            IWebElement addNew = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
            addNew.Click();

            IWebElement text = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
            text.Click();
            text.SendKeys("SGGS College");

            IWebElement countryName = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            countryName.Click();

            IWebElement namedropDownSelect = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
            namedropDownSelect.SendKeys("India");
            namedropDownSelect.Click();

            IWebElement titleBox = driver.FindElement(By.XPath("//div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            titleBox.Click();

            IWebElement titleDropDown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
            titleDropDown.SendKeys("B.Sc");
            titleDropDown.Click();

            IWebElement degreeBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
            degreeBox.Click();
            degreeBox.SendKeys("Graduation");

            IWebElement yearBox = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            yearBox.Click();

            IWebElement yearDropDown = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
            yearDropDown.SendKeys("2014");
            yearDropDown.Click();

            IWebElement addButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            addButton.Click();


        }
    }
}
