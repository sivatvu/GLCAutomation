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
    public class AppHome
    {

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='$b3']")]
        protected IWebElement MobileCreditScore { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='b4-DealsLink']")]
        protected IWebElement Offers { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='b4-ReportLink']")]
        protected IWebElement Report { get; set; }



        [FindsBy(How = How.ClassName, Using = "android.widget.Button")]
        protected IWebElement Enter { get; set; }


        

        public AppHome(AndroidDriver<AndroidElement> driver)
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

        public Boolean MobileCreditscoreDisplays()
        {

            return MobileCreditScore.Displayed;
            System.Threading.Thread.Sleep(1000);
        }

        public void ClickOffers()
        {

            Offers.Click();
            System.Threading.Thread.Sleep(10000);

        }

        public void ClickReport()
        {

            Report.Click();
            System.Threading.Thread.Sleep(10000);


        }


    }
}
