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
    public class iOSAppOffers
    {

        

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeButton[@name='Find offers for me']")]
        protected IWebElement iOSFindOffersforme { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@name='Loans']")]
        protected IWebElement iOSMyOffers { get; set; }



       




        public iOSAppOffers(IOSDriver<IOSElement> driver)
        {
            driver = driver;
            PageFactory.InitElements(driver, this);
        }
              

       

        public Boolean iOSVerifyFindOffersforme()
        {

            return iOSFindOffersforme.Displayed;
            


        }

        public void iOSClickFindOffersforme()
        {

            iOSFindOffersforme.Click();
            System.Threading.Thread.Sleep(20000);
            

        }

        public Boolean iOSVerifyMyOffers()
        {

            return iOSMyOffers.Displayed;



        }

    }
}
