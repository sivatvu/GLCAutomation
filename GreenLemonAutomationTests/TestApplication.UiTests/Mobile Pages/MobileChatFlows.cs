using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
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
    public class MobileChatFlows
    {
        private IWebDriver driver;

        [FindsBy(How = How.ClassName, Using = "android.view.View")]
        protected IWebElement MobileCreditScore { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='b4-GoalsLink']")]
        protected IWebElement ClickGoalsIcon { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='l1-1-EnterChatFlow']")]
        protected IWebElement BuyaHouseChatWindow { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='l1-0-b3-Message']")]
        protected IWebElement ChatWindowAppears { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='l2-0-OptionLink']")]
        protected IWebElement Notyet { get; set; }

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View[2]/android.view.View/android.view.View[3]/android.view.View[7]/android.view.View/android.view.View/android.view.View[2]")]
        protected IWebElement Autochatverify { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='RestartPlanLink']")]
        protected IWebElement RestartPlanLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='l1-7-b3-Message']")]
        protected IWebElement RestartChat { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[@resource-id='l1-6-b3-Message']")]
        protected IWebElement AutoChatResponse { get; set; }


        public MobileChatFlows(AndroidDriver<AndroidElement> driver)
        {
            driver = driver;
            PageFactory.InitElements(driver, this);
        }






        public void StartChat()
        {

           Notyet.Click();
            System.Threading.Thread.Sleep(1000);
            

        }

        public void ChatBuyaHouse()
        {
            BuyaHouseChatWindow.Click();
            System.Threading.Thread.Sleep(10000);
        }

        public Boolean MobileCreditscoreDisplays()
        {

            return MobileCreditScore.Displayed;
            System.Threading.Thread.Sleep(1000);
        }

        public void GoalsIcon()
        {
            //WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            //IWebElement GoalsIcon = wait.Until(d => d.FindElement(By.Id("b4-GoalsLink")));
            ClickGoalsIcon.Click();
            System.Threading.Thread.Sleep(1000);
        }

        public void ChatWindow()
        {

            var CW = ChatWindowAppears;
            Assert.IsTrue(CW.Displayed);
            System.Threading.Thread.Sleep(10000);

            

        }

        public Boolean MobileChatfunctions()
        {

            return Autochatverify.Displayed;
            
        }

        public void ClickRestartPlanLink()
        {

            RestartPlanLink.Click();
            System.Threading.Thread.Sleep(10000);


        }


        public Boolean VerifyRestartLink()
        {

            return RestartChat.Displayed;

        }

        public Boolean VerifyAutoChatResponse()
        {

            return AutoChatResponse.Displayed;

        }

    }
}
