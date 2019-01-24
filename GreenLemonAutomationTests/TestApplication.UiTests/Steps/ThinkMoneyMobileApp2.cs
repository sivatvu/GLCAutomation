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
    public class ThinkMoneyMobileApp2: AppiumBase
    {
        

        [Given(@"I navigate to the test site in my Mobile")]
        public void GivenINavigateToTheTestSiteInMyMobile()
        {
            setup2();
            AppLoginPage Aplp = new AppLoginPage(driver);
            Assert.IsNotNull(driver.Context);
            System.Threading.Thread.Sleep(2000);
            
            
          
           
             //AndroidElement searchElement = new RemoteWebDriver(AndroidDriver<AndroidElement> driver, TimeSpan.FromSeconds(30)).Until(ExpectedConditions.ElementToBeClickable(MobileBy.ClassName("android.widget.Button")));
            //searchElement.Click();

            //ReadOnlyCollection<AndroidElement> allProductsName = driver.FindElements(By.ClassName("android.widget.Button"));
            //driver.FindElement(By.ClassName("android.widget.Button")).Click();
            //Signup.Click();
            //driver.Quit();
        }


        [When(@"I Click on Sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            AppLoginPage Aplp = new AppLoginPage(driver);
            Aplp.Signup();
        }


        [When(@"I enter Username, Password & Re-Type Password in App")]
        public void WhenIEnterUsernamePasswordRe_TypePasswordInApp()
        {
            AppLoginPage Aplp = new AppLoginPage(driver);
            Aplp.Login();
        }

        [When(@"I click on Enter button")]
        public void WhenIClickOnEnterButton()
        {
            AppLoginPage Aplp = new AppLoginPage(driver);
            Aplp.EnterLogin();
            System.Threading.Thread.Sleep(3000);
        }

        [When(@"I entered all the details to Sign up and click on Next")]
        public void WhenIEnteredAllTheDetailsToSignUpAndClickOnNext()
        {
            AppLoginPage Aplp = new AppLoginPage(driver);
            Aplp.EnterPersonalDetails();
        }



        [When(@"I enter the FirstName")]
        public void WhenIEnterTheFirstName()
        {
            AppLoginPage Aplp = new AppLoginPage(driver);
            Aplp.EnterFN();

        }

        [When(@"I enter the Sur Name")]
        public void WhenIEnterTheSurName()
        {
            AppLoginPage Aplp = new AppLoginPage(driver);
            Aplp.EnterSN();
        }

        [When(@"I enter the users Date of Birth")]
        public void WhenIEnterTheUsersDateOfBirth()
        {
            AppLoginPage Aplp = new AppLoginPage(driver);
            Aplp.EnterDOB();
        }

        [When(@"I enter my Telephone No")]
        public void WhenIEnterMyTelephoneNo()
        {
            AppLoginPage Aplp = new AppLoginPage(driver);
            Aplp.EnterTN();
        }

        [When(@"I select Employment")]
        public void WhenISelectEmployment()
        {
            AppLoginPage Aplp = new AppLoginPage(driver);
            driver.Quit();
          
        }

        [When(@"I click on Login button")]
        public void WhenIClickOnLoginButton()
        {
            AppLoginPage Aplp = new AppLoginPage(driver);
            Aplp.MobileClickLogin();
            
        }


        [When(@"I Login as the test user")]
        public void WhenILoginAsTheTestUser()
        {
            AppLoginPage Aplp = new AppLoginPage(driver);
            Aplp.MLogin();
            

        }

        [When(@"I click on Goals Icon")]
        public void WhenIClickOnGoalsIcon()
        {
            MobileChatFlows Mcf = new MobileChatFlows(driver);
            Mcf.GoalsIcon();

        }
        [When(@"I can autochat to Buy a House")]
        public void WhenICanAutochatToBuyAHouse()
        {
            MobileChatFlows Mcf = new MobileChatFlows(driver);
            Mcf.ChatBuyaHouse();
            
        }

        [When(@"I click on Not Yet for the question First, do you already own a property\?")]
        public void WhenIClickOnNotYetForTheQuestionFirstDoYouAlreadyOwnAProperty()
        {
            MobileChatFlows Mcf = new MobileChatFlows(driver);
            Mcf.StartChat();
        }

        [When(@"I click on Restart Plan")]
        public void WhenIClickOnRestartPlan()
        {
            MobileChatFlows Mcf = new MobileChatFlows(driver);
            Mcf.ClickRestartPlanLink();
        }

        [When(@"I click on Deals")]
        public void WhenIClickOnDeals()
        {
            AppHome Ahp = new AppHome(driver);
            Ahp.ClickOffers();
        }

        [When(@"I click on Find offers for me Button")]
        public void WhenIClickOnFindOffersForMeButton()
        {
            AppHome Ahp = new AppHome(driver);
            Ahp.ClickReport();
            
        }

        [When(@"I click on Reports")]
        public void WhenIClickOnReports()
        {
            AppHome Ahp = new AppHome(driver);
            Ahp.ClickReport();
        }

        [When(@"I click on About You tab")]
        public void WhenIClickOnAboutYouTab()
        {
            Reports rp = new Reports(driver);
            rp.ClickAboutYou();
        }

        [When(@"I click on Accounts")]
        public void WhenIClickOnAccounts()
        {
            Reports rp = new Reports(driver);
            rp.ClickAccounts();
        }

        [When(@"I click on Corrections")]
        public void WhenIClickOnCorrections()
        {
            Reports rp = new Reports(driver);
            rp.ClickCorrections();
        }

        [When(@"I click on Searches")]
        public void WhenIClickOnSearches()
        {
            Reports rp = new Reports(driver);
            rp.ClickSearches();
        }



        [Then(@"I can see the user's credit score")]
        public void ThenICanSeeTheUserSCreditScore()
        {
            AppHome Ahp = new AppHome(driver);
            Ahp.MobileCreditscoreDisplays();
            driver.Quit();
        }

        [Then(@"the autochat window opens")]
        public void ThenTheAutochatWindowOpens()
        {
            MobileChatFlows Mcf = new MobileChatFlows(driver);
            Mcf.ChatWindow();
        }

        [Then(@"I can see the Auto response as - Ok, and when you get your new property")]
        public void ThenICanSeeTheAutoResponseAs_OkAndWhenYouGetYourNewProperty()
        {
            MobileChatFlows Mcf = new MobileChatFlows(driver);
            Mcf.VerifyAutoChatResponse();
        }

        [Then(@"the chat windows restarts")]
        public void ThenTheChatWindowsRestarts()
        {
            MobileChatFlows Mcf = new MobileChatFlows(driver);
            Mcf.VerifyRestartLink();
            driver.Quit();
        }

        [Then(@"I can see the Find offers for me Page")]
        public void ThenICanSeeTheFindOffersForMePage()
        {
            AppOffers AOP = new AppOffers(driver);
            AOP.VerifyFindOffersforme();
        }

        [Then(@"I can see my offers")]
        public void ThenICanSeeMyOffers()
        {
            AppOffers AOP = new AppOffers(driver);
            AOP.VerifyMyOffers();
            driver.Quit();
        }

        [Then(@"I can see the Overview report")]
        public void ThenICanSeeTheOverviewReport()
        {
            Reports rp = new Reports(driver);
            rp.VerifyOverview();
        }

        [Then(@"I can see my address and Current Address")]
        public void ThenICanSeeMyAddressAndCurrentAddress()
        {
            Reports rp = new Reports(driver);
            rp.VerifyAddress();
        }

        [Then(@"I can see my Credit cards, Current accounts and Loans")]
        public void ThenICanSeeMyCreditCardsCurrentAccountsAndLoans()
        {
            Reports rp = new Reports(driver);
            rp.VerifyCreditCards();
        }

        [Then(@"I can see the number of corrections")]
        public void ThenICanSeeTheNumberOfCorrections()
        {
            Reports rp = new Reports(driver);
            rp.VerifyNumberOfCorrections();
        }

        [Then(@"I can search for the Credit application searches")]
        public void ThenICanSearchForTheCreditApplicationSearches()
        {
            Reports rp = new Reports(driver);
            rp.VerifyCreditApplicationSearches();
            driver.Quit();
        }
        [Then(@"I can set up the Credit Report")]
        public void ThenICanSetUpTheCreditReport()
        {
            driver.Quit();
        }

    }
}
