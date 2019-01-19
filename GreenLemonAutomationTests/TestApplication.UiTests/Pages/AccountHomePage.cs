using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace TestApplication.UiTests.Pages
{
    public class AccountHomePage
    {

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Homepage')]")]
        protected IWebElement CreditHomePage { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'259')]")]
        protected IWebElement CreditScore { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='radio' and @value='1'][2]")]
        protected IWebElement Question2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='radio' and @value='1'][3]")]
        protected IWebElement Question3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='submit' and @value='Enter']")]
        protected IWebElement EntertheAnswers { get; set; }




        private IWebDriver _driver;


        public AccountHomePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }



        public void CredithomePage()
        {
            IWebElement element = _driver.FindElement(By.XPath("//*[contains(text(),'Homepage')]"));
            Assert.IsTrue(element.Displayed);
        }

        public void CreditS()
        {
            IWebElement element = _driver.FindElement(By.XPath("//*[contains(text(),'259')]"));
            Assert.IsTrue(element.Displayed);
            _driver.Quit();
        }



        public void SubmittheAnswers()
        {
            EntertheAnswers.Click();
        }
    }
}
