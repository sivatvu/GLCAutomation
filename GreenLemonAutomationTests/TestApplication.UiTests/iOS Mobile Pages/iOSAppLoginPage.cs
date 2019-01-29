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
    public class iOSAppLoginPage
    {

       
        [FindsBy(How = How.XPath, Using = "//android.widget.Button[@resource-id='Next']")]
        protected IWebElement Next { get; set; }



        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeButton[@name='Sign up']")]
        protected IWebElement SignUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeTextField[@value='Username']")]
        protected IWebElement Username { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeSecureTextField[@value='Password']")]
        protected IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='PasswordRIn']")]
        protected IWebElement ReTypePassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.widget.Button[contains(@text,'Enter')]")]
        protected IWebElement Enter { get; set; }


        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeButton[@name='Login']")]
        protected IWebElement MobileLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeTextField[@value='Username']")]
        protected IWebElement EnterUsername { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeSecureTextField[@value='Password']")]
        protected IWebElement EnterPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//XCUIElementTypeButton[@name='Login']")]
        protected IWebElement ClickLogin { get; set; }

        


        public iOSAppLoginPage(IOSDriver<IOSElement> driver)
        {
            driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void iOSSignup()
        {
            SignUp.Click();
            System.Threading.Thread.Sleep(10000);
            
        }

        public void iOSMobileClickLoginButton()
        {
            MobileLogin.Click();

            System.Threading.Thread.Sleep(10000);


        }

        public void iOSMLogin()
        {
            EnterUsername.SendKeys(ConfigurationManager.AppSettings["MobileUsername"]);
            EnterPassword.SendKeys(ConfigurationManager.AppSettings["MobilePassword"]);
            ClickLogin.Click();
            System.Threading.Thread.Sleep(20000);

        }


        public void iOSEnterLogin()
        {

            Enter.Click();
            System.Threading.Thread.Sleep(1000);


        }

        

    }
}

// Enter = //android.widget.Button[contains(@text,'Enter')]
//Title = //android.view.View[contains(@text,'Mr.')]
//Employment Status = //android.view.View[contains(@text,'Self Employed')]
//Residential Status = //android.view.View[contains(@text,'Homeowner')]
//First Name = //android.widget.EditText[@resource-id='FNameIn']
//Surname = //android.widget.EditText[@resource-id='SNameIn']
//DOB = //android.widget.Spinner[@resource-id='DOBIn']
//Surname = //android.widget.EditText[@resource-id='PhoneNumberIn']
//GAI = //android.widget.EditText[@resource-id='GAIIn']
//HouseNo = //android.widget.EditText[@resource-id='b14-l4-0-Input_StreetNumber']
//PostCode = //android.widget.EditText[@resource-id='b14-l4-0-Input_PostCode']
//Move in year = //android.view.View[contains(@text,'2019')]
//Find my address = //android.widget.Button[contains(@text,'Find my address')]
//Select Find my address = //android.widget.Button[contains(@text,'Select')]

//Next = //android.widget.Button[@resource-id='Next']