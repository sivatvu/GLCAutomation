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
    public class CreditReportAuthentication
    {

        [FindsBy(How = How.XPath, Using = "//div[@class='Heading1' and text()='Credit Report authentication']")]
        protected IWebElement CRATitle { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'LLOYDS BANK')]")]
        protected IWebElement Question1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'£ 1000 to £ 1499')]")]
        protected IWebElement Question2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'CARPHONE WAREHOUSE')]")]
        protected IWebElement Question3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='submit' and @value='Enter']")]
        protected IWebElement EntertheAnswers { get; set; }




        private IWebDriver _driver;


        public CreditReportAuthentication(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        

       public void CRAPage()
        {
            IWebElement element = _driver.FindElement(By.XPath("//*[text()='Home']"));
            Assert.IsTrue(element.Displayed);
        }

        public void AnswertheQuestions()
        {
            Question1.Click();
            Question2.Click();
            //Question3.Click();
        }

        public void SubmittheAnswers()
        {
            EntertheAnswers.Click();
        }
    }
}
