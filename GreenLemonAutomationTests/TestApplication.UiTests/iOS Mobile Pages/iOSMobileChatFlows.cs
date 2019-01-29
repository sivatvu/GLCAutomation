using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.UiTests.Pages
{
    public class iOSMobileChatFlows
    {
        private IWebDriver driver;

        [FindsBy(How = How.ClassName, Using = "android.view.View")]
        protected IWebElement MobileCreditScore { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@name='Goals']")]
        protected IWebElement iOSClickGoalsIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@name='Buy a house']")]
        protected IWebElement iOSBuyaHouseChatWindow { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeLink[@name='Not yet']")]
        protected IWebElement iOSChatWindowAppears { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@name='Not yet']")]
        protected IWebElement iOSNotyet { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@name='Ok, and when you get your new property, will you live in it or rent it out?']")]
        protected IWebElement iOSAutochatverify { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeLink[@name='Restart plan']")]
        protected IWebElement iOSRestartPlanLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeStaticText[@name='Not yet']")]
        protected IWebElement iOSRestartChat { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='l1-16-b3-Content']")]
        protected IWebElement AutoChatResponse { get; set; }


        public iOSMobileChatFlows(IOSDriver<IOSElement> driver)
        {
            driver = driver;
            PageFactory.InitElements(driver, this);
        }






        public void iOSStartChat()
        {

           iOSNotyet.Click();
            System.Threading.Thread.Sleep(10000);
            

        }

        public void iOSChatBuyaHouse()
        {
            iOSBuyaHouseChatWindow.Click();
            System.Threading.Thread.Sleep(20000);
        }

        public Boolean MobileCreditscoreDisplays()
        {

            return MobileCreditScore.Displayed;
            System.Threading.Thread.Sleep(1000);
        }

        public void iOSGoalsIcon()
        {
            //WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            //IWebElement GoalsIcon = wait.Until(d => d.FindElement(By.Id("b4-GoalsLink")));
            iOSClickGoalsIcon.Click();
            System.Threading.Thread.Sleep(1000);
        }

        public void iOSChatWindow()
        {

            var CW = iOSChatWindowAppears;
            Assert.IsTrue(CW.Displayed);
            System.Threading.Thread.Sleep(10000);

            

        }

        public Boolean iOSMobileChatfunctions()
        {

            return iOSAutochatverify.Displayed;
            
        }

        public void iOSClickRestartPlanLink()
        {
            var element = iOSRestartPlanLink;
            Actions actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Perform();

            iOSRestartPlanLink.Click();
            System.Threading.Thread.Sleep(10000);


        }


        public Boolean iOSVerifyRestartLink()
        {

            return iOSRestartChat.Displayed;

        }

        public Boolean VerifyAutoChatResponse()
        {

            return AutoChatResponse.Displayed;

        }

    }
}
