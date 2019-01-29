using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.UiTests.Pages
{
    public class iOSReports
    {

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@name='ABOUT YOU']")]
        protected IWebElement iOSAboutYou { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='b4-DealsLink']")]
        protected IWebElement Offers { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@name='OVERVIEW']")]
        protected IWebElement iOSOverview { get; set; }



        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@name='Current address']")]
        protected IWebElement iOSCurrentAddress { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@name='ACCOUNTS']")]
        protected IWebElement iOSAccounts { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@name='Credit cards']")]
        protected IWebElement iOSCreditCards { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@name='CORRECTIONS']")]
        protected IWebElement iOSCorrections { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@name='0 corrections']")]
        protected IWebElement iOSNumberOfCorrections { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@name='SEARCHES']")]
        protected IWebElement iOSSearches { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@name='Credit application (hard) searches']")]
        protected IWebElement iOSCreditApplicationSearches { get; set; }


        public iOSReports(IOSDriver<IOSElement> driver)
        {
            driver = driver;
            PageFactory.InitElements(driver, this);
        }






        public void iOSClickAboutYou()
        {

            iOSAboutYou.Click();
            System.Threading.Thread.Sleep(1000);
            

        }

       
        public void ClickOffers()
        {

            Offers.Click();
            System.Threading.Thread.Sleep(10000);

        }

       

        public Boolean iOSVerifyOverview()
        {

            return iOSOverview.Displayed;
            
        }

        public Boolean iOSVerifyAddress()
        {

            return iOSCurrentAddress.Displayed;

        }

        public void iOSClickAccounts()
        {

            iOSAccounts.Click();
            System.Threading.Thread.Sleep(1000);

        }

        public Boolean iOSVerifyCreditCards()
        {

            return iOSCreditCards.Displayed;

        }

        public void iOSClickCorrections()
        {

            iOSCorrections.Click();
            System.Threading.Thread.Sleep(1000);

        }

        public Boolean iOSVerifyNumberOfCorrections()
        {

            return iOSNumberOfCorrections.Displayed;

        }

        public void iOSClickSearches()
        {

            iOSSearches.Click();
            System.Threading.Thread.Sleep(1000);

        }

        public Boolean iOSVerifyCreditApplicationSearches()
        {

            return iOSCreditApplicationSearches.Displayed;

        }
    }
}
