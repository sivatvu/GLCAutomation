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
    public class iOSAppHome
    {

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeButton[@name='KBA']")]
        protected IWebElement MobileCreditScore { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeLink[@name='Deals']")]
        protected IWebElement iOSOffers { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@name='Report']")]
        protected IWebElement iOSReport { get; set; }



        [FindsBy(How = How.ClassName, Using = "android.widget.Button")]
        protected IWebElement Enter { get; set; }


        

      

        public iOSAppHome(IOSDriver<IOSElement> driver)
        {
            driver = driver;
            PageFactory.InitElements(driver, this);
        }





        public void EnterLogin()
        {

            Enter.Click();
            System.Threading.Thread.Sleep(1000);
            Enter.Click();

        }

        public Boolean iOSMobileCreditscoreDisplays()
        {

            return MobileCreditScore.Displayed;
            System.Threading.Thread.Sleep(1000);
        }

        public void iOSClickOffers()
        {

            iOSOffers.Click();
            System.Threading.Thread.Sleep(10000);

        }

        public void iOSClickReport()
        {

            iOSReport.Click();
            System.Threading.Thread.Sleep(10000);


        }


    }
}
