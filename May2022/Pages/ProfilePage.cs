using May2022.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace May2022.Pages
{
    public class ProfilePage
    {
        
        IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")]
        IWebElement addNewButton;

        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")]
        IWebElement textBox;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")]
        IWebElement dropDown;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")]
        IWebElement dropDownSelect;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")]
        IWebElement addButton;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[1]/i")]
        IWebElement editButton;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[1]/input")]
        IWebElement editedLanguagetextbox;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/div[2]/select")]
        IWebElement lvlTextBox;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]")]
        IWebElement updateButton;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[3]/span[2]/i")]
        IWebElement deleteButton;

        [FindsBy(How = How.XPath, Using = "//div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[1]")]
        IWebElement language;

        [FindsBy(How = How.XPath, Using = "//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[last()]/tr/td[2]")]
        IWebElement lvl;

        public ProfilePage(IWebDriver driver)
        {
           this.driver = driver;

            PageFactory.initElements(driver, this);
        }
        public ProfilePage()
        {

        }
        public void addLanguage()
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
        public void editLanguage(IWebDriver driver, string language, string lvl)
        {
            // Thread.Sleep(4000);
            // IWebElement editButton = driver.FindElement(By.XPath("//div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[3]/tr/td[3]/span[1]//child::i[@class='outline write icon']"));
            wait.waitByClick(driver, "xPath", editButton, 2);
            editButton.Click();

            //This is textbox here
            editedLanguagetextbox.Clear();
            editedLanguagetextbox.SendKeys(language);

            //Level Text box
            lvlTextBox.SendKeys(lvl);
            lvlTextBox.Click();

            //Thread.Sleep(4000);
            //This is update button which will actually update
            wait.waitByClick(driver, "xPath", updateButton, 2);
            updateButton.Click();
        }
        public void deleteLanguage(IWebDriver driver)
        {
            Thread.Sleep(2000);

            wait.waitByClick(driver, "xPath", deleteButton, 2);
            deleteButton.Click();
        }
        public string getLastLanguage()
        {
            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", language, 2);
            return language.Text;
        }
        public string getLastLevel()
        {
            //Thread.Sleep(2000);
            wait.waitByClick(driver, "xPath", lvl, 2);
            return lvl.Text;
        }
    }
}
