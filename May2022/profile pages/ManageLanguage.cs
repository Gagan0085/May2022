using May2022.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace May2022.profile_pages
{
    public class ManageLanguage
    {
        public IWebDriver driver;
        // Add Language
        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]")]
        public IWebElement LanguageButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")]
        public IWebElement addNewButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")]
        public IWebElement textBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")]
        public IWebElement dropDown { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")]
        public IWebElement dropDownSelect { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")]
        public IWebElement addButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i")]
        public IWebElement editButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input")]
        public IWebElement editedLanguagetextbox { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")]
        public IWebElement deleteButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")]
        public IWebElement language { get; set; }

        public ManageLanguage(IWebDriver driver)
        {
            this.driver = driver;

            PageFactory.InitElements(driver, this);
        }
        public void addLanguage(IWebDriver driver)
        {

            // Thread.Sleep(2000);

            IWebElement language = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            language.Click();

            addNewButton.Click();

            textBox.Click();

            textBox.SendKeys("English");
            dropDown.Click();
            dropDownSelect.SendKeys("Conversational");
            dropDownSelect.Click();
            addButton.Click();
        }
        public void editLanguage(IWebDriver driver)
        {
            //This is textbox here
            editedLanguagetextbox.Click();
            editButton.Click();
            editedLanguagetextbox.Clear();
            editedLanguagetextbox.SendKeys("EditedLanguage");
            addButton.Click();
        }

        public void deleteLanguage(IWebDriver driver)
        {
            deleteButton.Click();
        }

        public string getLastLanguage()
        {
            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", language, 2);
            return language.Text;
        }
    }
}
