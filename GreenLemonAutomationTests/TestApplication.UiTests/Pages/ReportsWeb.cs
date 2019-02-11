using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.UiTests.Pages
{
    public class ReportsWeb
    {

        private readonly IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'About you')]")]
        protected IWebElement AboutYou { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='b4-DealsLink']")]
        protected IWebElement Offers { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Overview')]")]
        protected IWebElement Overview { get; set; }



        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Current address:')]")]
        protected IWebElement CurrentAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Accounts')]")]
        protected IWebElement Accounts { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Credit cards')]")]
        protected IWebElement CreditCards { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Corrections')]")]
        protected IWebElement Corrections { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'A Notice of Correction is your chance to explain w')]")]
        protected IWebElement NumberOfCorrections { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Searches')]")]
        protected IWebElement Searches { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Credit application (hard) searches')]")]
        protected IWebElement CreditApplicationSearches { get; set; }


        public ReportsWeb(IWebDriver driver)
        {
            driver = driver;
            PageFactory.InitElements(driver, this);
        }






        public void ClickAboutYou()
        {

            AboutYou.Click();
            System.Threading.Thread.Sleep(1000);
            

        }

       
        public void ClickOffers()
        {

            Offers.Click();
            System.Threading.Thread.Sleep(10000);

        }

       

        public Boolean VerifyOverview()
        {

            return Overview.Displayed;
            
        }

        public Boolean VerifyAddress()
        {

            return CurrentAddress.Displayed;

        }

        public void ClickAccounts()
        {

            Accounts.Click();
            System.Threading.Thread.Sleep(1000);

        }

        public Boolean VerifyCreditCards()
        {

            return CreditCards.Displayed;

        }

        public void ClickCorrections()
        {

            Corrections.Click();
            System.Threading.Thread.Sleep(1000);

        }

        public Boolean VerifyNumberOfCorrections()
        {

            return NumberOfCorrections.Displayed;

        }

        public void ClickSearches()
        {

            Searches.Click();
            System.Threading.Thread.Sleep(1000);

        }

        public Boolean VerifyCreditApplicationSearches()
        {

            return CreditApplicationSearches.Displayed;

        }
    }
}
