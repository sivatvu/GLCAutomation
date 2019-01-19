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


        [When(@"I enter Username, Password & Re-Type Password in App")]
        public void WhenIEnterUsernamePasswordRe_TypePasswordInApp()
        {
            AppLoginPage Aplp = new AppLoginPage(driver);
            Aplp.Signup();
            Aplp.Login();
        }

        [When(@"I click on Enter button")]
        public void WhenIClickOnEnterButton()
        {
            AppLoginPage Aplp = new AppLoginPage(driver);
            Aplp.EnterLogin();
            System.Threading.Thread.Sleep(3000);
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
            driver.Quit();

        }



    }
}
