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
    public class AppLoginPage
    {

        [FindsBy(How = How.LinkText, Using = "Council Tenant")]
        protected IWebElement CouncilTenant { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text,'Mr.')]")]
        protected IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@resource-id='FNameIn']")]
        protected IWebElement FN { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@resource-id='SNameIn']")]
        protected IWebElement SN { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.widget.Spinner[@resource-id='DOBIn']")]
        protected IWebElement DOB { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@resource-id='PhoneNumberIn']")]
        protected IWebElement TN { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text,'Self Employed')]")]
        protected IWebElement Emp { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text,'Homeowner')]")]
        protected IWebElement ResiStatus { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@resource-id='GAIIn']")]
        protected IWebElement GrossAnnualIncome { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@resource-id='b14-l4-0-Input_StreetNumber']")]
        protected IWebElement HouseNo { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@resource-id='b14-l4-0-Input_PostCode']")]
        protected IWebElement PostCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.view.View[contains(@text,'2019')]")]
        protected IWebElement MoveinYear { get; set; }
        [FindsBy(How = How.XPath, Using = "//android.widget.Button[contains(@text,'Find my address')]")]
        protected IWebElement FindMyAddress { get; set; }
        [FindsBy(How = How.XPath, Using = "//android.widget.Button[contains(@text,'Select')]")]
        protected IWebElement SelectAddress { get; set; }
        [FindsBy(How = How.XPath, Using = "//android.widget.Button[@resource-id='Next']")]
        protected IWebElement Next { get; set; }



        [FindsBy(How = How.XPath, Using = "//*[@resource-id='SignUp']")]
        protected IWebElement SignUp { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='UsernameIn']")]
        protected IWebElement Username { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='PasswordIn']")]
        protected IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='PasswordRIn']")]
        protected IWebElement ReTypePassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.widget.Button[contains(@text,'Enter')]")]
        protected IWebElement Enter { get; set; }


        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View[2]/android.view.View/android.view.View[3]/android.widget.Button")]
        protected IWebElement MobileLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@resource-id='Input_UsernameVal']")]
        protected IWebElement EnterUsername { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.widget.EditText[@resource-id='Input_PasswordVal']")]
        protected IWebElement EnterPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//android.widget.Button[@resource-id='LoginButton']")]
        protected IWebElement ClickLogin { get; set; }

        


        public AppLoginPage(AndroidDriver<AndroidElement> driver)
        {
            driver = driver;
            PageFactory.InitElements(driver, this);
        }


        public void EnterPersonalDetails()
        {
            Title.Click();
            FN.SendKeys(ConfigurationManager.AppSettings["Firstname"]);
            SN.SendKeys(ConfigurationManager.AppSettings["Surname"]);
            DOB.SendKeys(ConfigurationManager.AppSettings["DOB"]);
            TN.SendKeys(ConfigurationManager.AppSettings["Telephonenumber"]);
            Emp.Click();
            ResiStatus.Click();
            GrossAnnualIncome.SendKeys(ConfigurationManager.AppSettings["GAI"]);
            HouseNo.SendKeys(ConfigurationManager.AppSettings["House"]);
            PostCode.SendKeys(ConfigurationManager.AppSettings["PCode"]);
            MoveinYear.SendKeys(ConfigurationManager.AppSettings["Year"]);
            FindMyAddress.Click();
            System.Threading.Thread.Sleep(1000);
            //SelectAddress.Click();
            //System.Threading.Thread.Sleep(1000);
            Next.Click();
        }

        public void Signup()
        {
            SignUp.Click();
            System.Threading.Thread.Sleep(10000);
        }

       

        public void Login()
        {
            Username.SendKeys(ConfigurationManager.AppSettings["Username"]);
            Password.SendKeys(ConfigurationManager.AppSettings["Password"]);
            ReTypePassword.SendKeys(ConfigurationManager.AppSettings["Re-Type Password"]);
        }

        public void EnterLogin()
        {

            Enter.Click();
            System.Threading.Thread.Sleep(1000);
            

        }


        public void EnterFN()
        {

            //Title.Click();
            FN.SendKeys(ConfigurationManager.AppSettings["Firstname"]);
            
            //Emp.Click();
            
        }

        public void EnterSN()
        {
            SN.SendKeys(ConfigurationManager.AppSettings["Surname"]);
            
        }

        public void EnterDOB()
        {
            DOB.SendKeys(ConfigurationManager.AppSettings["DOB"]);
            
        }

        public void EnterTN()
        {
            TN.SendKeys(ConfigurationManager.AppSettings["Telephonenumber"]);
        }
        //public Boolean PhoneNoDisplays()
        //{

        //    return PhoneNumber.Displayed;
        //}

        public void MobileClickLogin()
        {
            MobileLogin.Click();

            System.Threading.Thread.Sleep(10000);


        }

        public void MLogin()
        {
            EnterUsername.SendKeys(ConfigurationManager.AppSettings["MobileUsername"]);
            EnterPassword.SendKeys(ConfigurationManager.AppSettings["MobilePassword"]);
            ClickLogin.Click();
            System.Threading.Thread.Sleep(20000);

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