﻿using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System.Configuration;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using TestApplication.UiTests.Utils;
using TestApplication.UiTests.Pages;
using System.Linq;
using TechTalk.SpecFlow.Assist;
using static TestApplication.UiTests.Pages.PersonalDetails;

namespace CBT_Example_2
{

    [Binding]
    public class ThinkMoney : Base
    {
        #region given

        [Given(@"I navigate to the test site")]
        public void GivenINavigateToTheTestSite()
        {
            SetUp();
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["ThinkMoney"]);
        }



        #endregion

        #region when 

        [When(@"I login as the test user")]
        public void WhenILoginAsTheTestUser()
        {
            driver.Navigate().GoToUrl(ConfigurationManager.AppSettings["ThinkMoneyLogin"]);
            LoginPage lp = new LoginPage(driver);
            lp.WebLogin();
            

        }


        [When(@"I enter Username, Password & Re-Type Password")]
        public void WhenIEnterUsernamePasswordRe_TypePassword()
        {
            LoginPage lp = new LoginPage(driver);
            lp.Login();
        }

        //[When(@"I enter the following values into the Personal Details page")]
        //public void WhenIEnterTheFollowingValuesIntoThePersonalDetailsPage(Table table)
        //{
           
        //   PersonalDetails accounts = table.CreateInstance<PersonalDetails>();

        //    accounts.FirstN("FirstName");
        //    accounts.SecondN("SurName");
        //    accounts.Tele("TelephoneNumber");
        //    accounts.GrossAnnual("DateOfBirth");
        //    accounts.DateOB("GrossAnnualIncome");
        //}


        
        [When(@"I enter the following values into the Personal Details page ""(.*)"", ""(.*)"", ""(.*)"", ""(.*)"" and ""(.*)""")]
        public void WhenIEnterTheFollowingValuesIntoThePersonalDetailsPageAnd(string FirstName, string SurName, string DateOfBirth, string TelephoneNumber, string GrossAnnualIncome)
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.FirstN(FirstName);
            pd.SecondN(SurName);
            pd.DateOB(DateOfBirth);
            pd.Tele(TelephoneNumber);
            pd.GrossAnnual(GrossAnnualIncome);
            

        }



        //[When(@"I enter the First Name")]
        //public void WhenIEnterTheFirstName()
        //{
        //    PersonalDetails pd = new PersonalDetails(driver);
        //    pd.FirstN();
        //}

        //[When(@"I enter the Surname")]
        //public void WhenIEnterTheSurname()
        //{
        //    PersonalDetails pd = new PersonalDetails(driver);
        //    pd.SecondN();
        //}

        //[When(@"I enter my Date of Birth")]
        //public void WhenIEnterMyDateOfBirth()
        //{
        //    PersonalDetails pd = new PersonalDetails(driver);
        //    pd.DateOB();
        //}

        //[When(@"I enter my Telephone Number")]
        //public void WhenIEnterMyTelephoneNumber()
        //{
        //    PersonalDetails pd = new PersonalDetails(driver);
        //    pd.Tele();
        //}

        [When(@"I have agreed with the Terms and Conditions")]
        public void WhenIHaveAgreedWithTheTermsAndConditions()
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.AgreeTermsandConditions();
        }






        [When(@"I select Employment and Residential Status")]
        public void WhenISelectEmploymentAndResidentialStatus()
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.SelectEmploymentandResidential();
        }



        [When(@"I click on Enter")]
        public void WhenIClickOnEnter()
        {
            LoginPage lp = new LoginPage(driver);
            lp.EnterLogin();
            
        }

        [When(@"I select the Title")]
        public void WhenISelectTheTitle()
        {
            
            PersonalDetails pd = new PersonalDetails(driver);
            pd.SelectTitle();
        }

        [When(@"I click on Address Search")]
        public void WhenIClickOnAddressSearch()
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.AddressSearch();
        }

        [When(@"I add my address")]
        public void WhenIAddMyAddress()
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.AddAddress();
        }





        [When(@"I click on YES to set up the credit report")]
        public void WhenIClickOnYESToSetUpTheCreditReport()
        {
            SetupCreditReport scr = new SetupCreditReport(driver);
            scr.SelectYestoSetup();
        }

        [When(@"I login as the test admin")]
        public void WhenILoginAsTheTestAdmin()
        {
            SetupCreditReport scr = new SetupCreditReport(driver);
            scr.LoginC();

        }

        [When(@"I Click on Enter on Personal Details Page")]
        public void WhenIClickOnEnterOnPersonalDetailsPage()
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.EnterPD();
        }

        //[When(@"I have entered my Gross annual Income")]
        //public void WhenIHaveEnteredMyGrossAnnualIncome()
        //{
        //    PersonalDetails pd = new PersonalDetails(driver);
        //    pd.GrossAnnual();
        //}

        [When(@"I enter my address")]
        public void WhenIEnterMyAddress()
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.Address();
        }

        [When(@"the month and year I moved in")]
        public void WhenTheMonthAndYearIMovedIn()
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.MovedInDates();
        }

        [When(@"I select the correct answers for the authentication questions")]
        public void WhenISelectTheCorrectAnswersForTheAuthenticationQuestions()
        {
            CreditReportAuthentication cra = new CreditReportAuthentication(driver);
            cra.AnswertheQuestions();
        }

        [When(@"I submit the answers by pressing the Enter button")]
        public void WhenISubmitTheAnswersByPressingTheEnterButton()
        {
            CreditReportAuthentication cra = new CreditReportAuthentication(driver);
            cra.SubmittheAnswers();
        }

        [When(@"I click on Offers")]
        public void WhenIClickOnOffers()
        {
            Offers op = new Offers(driver);
            op.ClickonOffers();
        }

        [When(@"I click on Find offers for me")]
        public void WhenIClickOnFindOffersForMe()
        {
            Offers op = new Offers(driver);
            op.ClickonFindofferstome();

        }


        [When(@"I click on ChatFlows")]
        public void WhenIClickOnChatFlows()
        {
            ChatFlows cfp = new ChatFlows(driver);
            cfp.ClickChat();
        }


        [When(@"I click on Actions button")]
        public void WhenIClickOnActionsButton()
        {
            ChatFlows cfp = new ChatFlows(driver);
            cfp.ClickActions();
        }


        [When(@"I click on Goals Button")]
        public void WhenIClickOnGoalsButton()
        {
            ChatFlows cfp = new ChatFlows(driver);
            cfp.ClickGoals();
        }

        [When(@"I click on Buy a car Chat Flow")]
        public void WhenIClickOnBuyACarChatFlow()
        {
            ChatFlows cfp = new ChatFlows(driver);
            cfp.ClickBuyaCarChat();
        }

        [When(@"I click on Let's do it")]
        public void WhenIClickOnLetSDoIt()
        {
            ChatFlows cfp = new ChatFlows(driver);
            cfp.StarttheChat();
        }

        [When(@"I click on the key symbol")]
        public void WhenIClickOnTheKeySymbol()
        {
            ChatFlows cfp = new ChatFlows(driver);
            cfp.Clickonthekey();
        }


        #endregion

        #region then

        [Then(@"I can see the test user's credit score")]
        public void ThenICanSeeTheTestUserSCreditScore()
        {
            Home hp = new Home(driver);
            hp.CreditscoreDisplays();
        }

        [Then(@"I can see the offers")]
        public void ThenICanSeeTheOffers()
        {
            Home hp = new Home(driver);
            hp.OffersDisplays();
        }

        [Then(@"I can see the ChatFlows")]
        public void ThenICanSeeTheChatFlows()
        {
            Home hp = new Home(driver);
            hp.ChatFlowsDisplays();
            driver.Quit();
        }




        [Then(@"I am on Create Account page")]
        public void ThenIAmOnCreateAccountPage()
        {
            LoginPage lp = new LoginPage(driver);
            lp.CreateAccountDisplays();
        }


        [Then(@"I can verify the credit score")]
        public void ThenICanVerifyTheCreditScore()
        {
            SetupCreditReport scr = new SetupCreditReport(driver);
            scr.CreditScorePage();
        }


        [Then(@"I can verify the Credit Report authentication")]
        public void ThenICanVerifyTheCreditReportAuthentication()
        {
            CreditReportAuthentication cra = new CreditReportAuthentication(driver);
            cra.CRAPage();
            driver.Quit();
        }

        [Then(@"I am on Credit report homepage")]
        public void ThenIAmOnCreditReportHomepage()
        {
            AccountHomePage ahp = new AccountHomePage(driver);
            ahp.CredithomePage();
        }

        [Then(@"I can see my Credit Score")]
        public void ThenICanSeeMyCreditScore()
        {
            AccountHomePage ahp = new AccountHomePage(driver);
            ahp.CreditS();
        }

        [Then(@"I can enter my personal details")]
        public void ThenICanEnterMyPersonalDetails()
        {
            PersonalDetails pd = new PersonalDetails(driver);
            pd.PersonalDetailDisplays();
        }


        [Then(@"I can successfully enter my personal details")]
        public void ThenICanSuccessfullyEnterMyPersonalDetails()
        {
            SetupCreditReport scr = new SetupCreditReport(driver);
            scr.CreditReportpageDisplays();
        }

        [Then(@"I can see offers for the test user")]
        public void ThenICanSeeOffersForTheTestUser()
        {
            Offers op = new Offers(driver);
            op.MyOffers();
            driver.Quit();
        }


        [Then(@"I can see the Actions and Goals button")]
        public void ThenICanSeeTheActionsAndGoalsButton()
        {
            ChatFlows cfp = new ChatFlows(driver);
            cfp.GoalandActions();
        }

        [Then(@"I am on Actions Page and I can see how to improve my credit score")]
        public void ThenIAmOnActionsPageAndICanSeeHowToImproveMyCreditScore()
        {
            ChatFlows cfp = new ChatFlows(driver);
            cfp.ActionsPage();
        }


        [Then(@"I can see the chat flows like Buy a car, Get credit etc\.,")]
        public void ThenICanSeeTheChatFlowsLikeBuyACarGetCreditEtc_()
        {
            ChatFlows cfp = new ChatFlows(driver);
            cfp.ChatCar();
        }

        [Then(@"I can see the chat window for Buy a car")]
        public void ThenICanSeeTheChatWindowForBuyACar()
        {
            ChatFlows cfp = new ChatFlows(driver);
            cfp.Chatbox();
        }


        [Then(@"I receive an automation responce as Let's put a key in the ignition and get started")]
        public void ThenIReceiveAnAutomationResponceAsLetSPutAKeyInTheIgnitionAndGetStarted()
        {
            ChatFlows cfp = new ChatFlows(driver);
            cfp.responce();
        }

        [Then(@"I can see my average running cost of a car")]
        public void ThenICanSeeMyAverageRunningCostOfACar()
        {
            ChatFlows cfp = new ChatFlows(driver);
            cfp.Verifythechat();
            driver.Quit();
        }


        #endregion
















    }
}