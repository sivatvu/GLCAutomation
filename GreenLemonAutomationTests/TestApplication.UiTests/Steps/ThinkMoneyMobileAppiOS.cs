using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestApplication.UiTests.Pages;
using TestApplication.UiTests.Utils;

namespace TestApplication.UiTests.Steps
{
   
    [Binding]
    public class ThinkMoneyMobileApp2iOS: AppiumiOSBase
    {
        
           

    

        [Given(@"I navigate to the test site on my iOS Mobile")]
        public void GivenINavigateToTheTestSiteOnMyIOSMobile()
        {
            setupiOS();
            iOSAppLoginPage iOSAplp = new iOSAppLoginPage(driver);
           
            System.Threading.Thread.Sleep(2000);
        }

        [When(@"I Click on Sign up button on iOS")]
        public void WhenIClickOnSignUpButtonOnIOS()
        {
            iOSAppLoginPage iOSAplp = new iOSAppLoginPage(driver);
            iOSAplp.iOSSignup();
            driver.Quit();
        }

        [When(@"I click on Login button on iOS")]
        public void WhenIClickOnLoginButtonOnIOS()
        {
            iOSAppLoginPage iOSAplp = new iOSAppLoginPage(driver);
            iOSAplp.iOSMobileClickLoginButton();
        }

        [When(@"I Login as the iOS test user")]
        public void WhenILoginAsTheIOSTestUser()
        {
            iOSAppLoginPage iOSAplp = new iOSAppLoginPage(driver);
            iOSAplp.iOSMLogin();

        }

        [When(@"I click on Goals Icon on iOS")]
        public void WhenIClickOnGoalsIconOnIOS()
        {
            iOSMobileChatFlows iMC = new iOSMobileChatFlows(driver);
            iMC.iOSGoalsIcon();
        }

        [When(@"I can autochat to Buy a House on iOS")]
        public void WhenICanAutochatToBuyAHouseOnIOS()
        {
            iOSMobileChatFlows iMC = new iOSMobileChatFlows(driver);
            iMC.iOSChatBuyaHouse();
        }



        [Then(@"I can see the iOS user's credit score")]
        public void ThenICanSeeTheIOSUserSCreditScore()
        {
            iOSAppHome iAH = new iOSAppHome(driver);
            iAH.iOSMobileCreditscoreDisplays();
            driver.Quit();
        }

        [Then(@"the autochat window opens on iOS")]
        public void ThenTheAutochatWindowOpensOnIOS()
        {
            iOSMobileChatFlows iMC = new iOSMobileChatFlows(driver);
            iMC.iOSChatWindow();
            driver.Quit();
        }


    }
}
