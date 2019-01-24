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
    public class Reports
    {

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='b3-Tab2']")]
        protected IWebElement AboutYou { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='b4-DealsLink']")]
        protected IWebElement Offers { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='b3-Tab1']")]
        protected IWebElement Overview { get; set; }



        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='b3-tabscontent']")]
        protected IWebElement CurrentAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='b3-Tab3']")]
        protected IWebElement Accounts { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='b5-CreditCardList']")]
        protected IWebElement CreditCards { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='b3-Tab3']")]
        protected IWebElement Corrections { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='b8-Title']")]
        protected IWebElement NumberOfCorrections { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='b3-Tab5']")]
        protected IWebElement Searches { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='b8-Title']")]
        protected IWebElement CreditApplicationSearches { get; set; }


        public Reports(AndroidDriver<AndroidElement> driver)
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
