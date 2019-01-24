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
    public class AppOffers
    {

        

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='FindOffers']")]
        protected IWebElement FindOffersforme { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='b1-Title']")]
        protected IWebElement MyOffers { get; set; }



       




        public AppOffers(AndroidDriver<AndroidElement> driver)
        {
            driver = driver;
            PageFactory.InitElements(driver, this);
        }
              

       

        public Boolean VerifyFindOffersforme()
        {

            return FindOffersforme.Displayed;
            


        }

        public void ClickFindOffersforme()
        {

            FindOffersforme.Click();
            System.Threading.Thread.Sleep(10000);
            

        }

        public Boolean VerifyMyOffers()
        {

            return MyOffers.Displayed;



        }

    }
}
