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
    public class SetupCreditReport
    {

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Mr.')]")]
        protected IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Mr.')]/following::input[1]")]
        protected IWebElement FN { get; set; }

        [FindsBy(How = How.CssSelector, Using = "//div[contains(text(),'Mr.')]/following::input[2]")]
        protected IWebElement SN { get; set; }

        [FindsBy(How = How.CssSelector, Using = "//div[contains(text(),'Mr.')]/following::input[3]")]
        protected IWebElement DOB { get; set; }

        [FindsBy(How = How.CssSelector, Using = "//div[contains(text(),'Mr.')]/following::input[4]")]
        protected IWebElement TN { get; set; }

        [FindsBy(How = How.CssSelector, Using = "//div[contains(text(),'Self Employed')]")]
        protected IWebElement Emp { get; set; }

        [FindsBy(How = How.CssSelector, Using = "//div[contains(text(),'Homeowner')]")]
        protected IWebElement ResD { get; set; }

        [FindsBy(How = How.CssSelector, Using = "//div[contains(text(),'Mr.')]/following::input[5]")]
        protected IWebElement Gross { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Want to set up your')]")]
        protected IWebElement CreditReportpage { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@tabindex='1']")]
        protected IWebElement UNC { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@tabindex='2']")]
        protected IWebElement PAC { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@tabindex='3']")]
        protected IWebElement LOGC { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Homepage')]")]
        protected IWebElement CScore { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@tabindex='1']")]
        protected IWebElement Yes { get; set; }



        private IWebDriver _driver;


        public SetupCreditReport(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void SelectTitle()
        {
            Title.Click();

        }

        public void NameAndDOB(string FirstName, string Surname, string DateofBirth, string Telephonenumber)
        {
            FN.SendKeys(FirstName);
            SN.SendKeys(Surname);
            DOB.SendKeys(DateofBirth);
            TN.SendKeys(Telephonenumber);


        }

        public void SelectEmploymentandResidential()
        {
            Emp.Click();
            ResD.Click();

        }

        public void SelectYestoSetup()
        {
            Yes.Click();


        }

        public Boolean CreditReportpageDisplays()
        {
            return CreditReportpage.Displayed;
        }

        public void LoginC()
        {
            UNC.SendKeys("admin");
            PAC.SendKeys("admin");
            LOGC.Click();



        }

        public void CreditScorePage()
        {
            
            var CSPage = _driver.FindElement(By.XPath("//div[contains(text(),'Homepage')]"));
            Assert.IsTrue(CSPage.Displayed);



        }

    }
}
