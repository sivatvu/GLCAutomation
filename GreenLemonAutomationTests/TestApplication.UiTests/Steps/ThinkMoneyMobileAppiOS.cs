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

        [When(@"I click on Not Yet for the question First, do you already own a property\? on iOS")]
        public void WhenIClickOnNotYetForTheQuestionFirstDoYouAlreadyOwnAPropertyOnIOS()
        {
            iOSMobileChatFlows iMC = new iOSMobileChatFlows(driver);
            iMC.iOSStartChat();
        }

        [When(@"I click on Restart Plan button")]
        public void WhenIClickOnRestartPlanButton()
        {
            iOSMobileChatFlows iMC = new iOSMobileChatFlows(driver);
            iMC.iOSClickRestartPlanLink();
        }

        [When(@"I click on Deals icon on iOS")]
        public void WhenIClickOnDealsIconOnIOS()
        {
            iOSAppHome iAH = new iOSAppHome(driver);
            iAH.iOSClickOffers();
        }
        [When(@"I click on Find offers for me Button on iOS")]
        public void WhenIClickOnFindOffersForMeButtonOnIOS()
        {
            iOSAppOffers iAO = new iOSAppOffers(driver);
            iAO.iOSClickFindOffersforme();
        }
        [When(@"I click on Reports on iOS")]
        public void WhenIClickOnReportsOnIOS()
        {
            iOSAppHome iAH = new iOSAppHome(driver);
            iAH.iOSClickReport();
        }

        [When(@"I click on About You tab on iOS")]
        public void WhenIClickOnAboutYouTabOnIOS()
        {
            iOSReports iRP = new iOSReports(driver);
            iRP.iOSClickAboutYou();
        }

        [When(@"I click on Accounts on iOS")]
        public void WhenIClickOnAccountsOnIOS()
        {
            iOSReports iRP = new iOSReports(driver);
            iRP.iOSClickAccounts();
        }
        [When(@"I click on Corrections on iOS")]
        public void WhenIClickOnCorrectionsOnIOS()
        {
            iOSReports iRP = new iOSReports(driver);
            iRP.iOSClickCorrections();
        }

        [When(@"I click on Searches on iOS")]
        public void WhenIClickOnSearchesOnIOS()
        {
            iOSReports iRP = new iOSReports(driver);
            iRP.iOSClickSearches();
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
            
        }

        [Then(@"I can see the Auto response as - Ok, and when you get your new property on iOS")]
        public void ThenICanSeeTheAutoResponseAs_OkAndWhenYouGetYourNewPropertyOnIOS()
        {
            iOSMobileChatFlows iMC = new iOSMobileChatFlows(driver);
            iMC.iOSMobileChatfunctions();
            driver.Quit();
           
        }
        [Then(@"the chat windows restarts on iOS")]
        public void ThenTheChatWindowsRestartsOnIOS()
        {
            iOSMobileChatFlows iMC = new iOSMobileChatFlows(driver);
            iMC.iOSVerifyRestartLink();
            

        }

        [Then(@"I can see the Find offers")]
        public void ThenICanSeeTheFindOffers()
        {
            iOSAppOffers iAO = new iOSAppOffers(driver);
            iAO.iOSVerifyFindOffersforme();
        }
        [Then(@"I can see my offers on my iOS device")]
        public void ThenICanSeeMyOffersOnMyIOSDevice()
        {
            iOSAppOffers iAO = new iOSAppOffers(driver);
            iAO.iOSVerifyMyOffers();
            driver.Quit();
        }

        [Then(@"I can see the Overview report on my iOS device")]
        public void ThenICanSeeTheOverviewReportOnMyIOSDevice()
        {
            iOSReports iRP = new iOSReports(driver);
            iRP.iOSVerifyOverview();
        }

        [Then(@"I can see my address and Current Address on iOS")]
        public void ThenICanSeeMyAddressAndCurrentAddressOnIOS()
        {
            iOSReports iRP = new iOSReports(driver);
            iRP.iOSVerifyAddress();
        }

        [Then(@"I can see my Credit cards, Current accounts and Loans on")]
        public void ThenICanSeeMyCreditCardsCurrentAccountsAndLoansOn()
        {
            iOSReports iRP = new iOSReports(driver);
            iRP.iOSVerifyCreditCards();
        }

        [Then(@"I can see the number of corrections on iOS")]
        public void ThenICanSeeTheNumberOfCorrectionsOnIOS()
        {
            iOSReports iRP = new iOSReports(driver);
            iRP.iOSVerifyNumberOfCorrections();
        }
        [Then(@"I can search for the Credit application searches on iOS")]
        public void ThenICanSearchForTheCreditApplicationSearchesOnIOS()
        {
            iOSReports iRP = new iOSReports(driver);
            iRP.iOSVerifyCreditApplicationSearches();
            driver.Quit();

        }

    }
}
