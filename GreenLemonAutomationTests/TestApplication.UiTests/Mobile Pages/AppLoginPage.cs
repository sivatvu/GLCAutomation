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

        [FindsBy(How = How.LinkText, Using = "Mr.")]
        protected IWebElement Title { get; set; }

        [FindsBy(How = How.ClassName, Using = "android.widget.EditText")]
        protected IWebElement FN { get; set; }

        [FindsBy(How = How.ClassName, Using = "android.widget.EditText")]
        protected IWebElement SN { get; set; }

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View[2]/android.view.View/android.view.View[2]/android.view.View[4]/android.view.View/android.view.View[1]/android.widget.Spinner")]
        protected IWebElement DOB { get; set; }

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View[2]/android.view.View/android.view.View[2]/android.view.View[5]/android.view.View/android.view.View[1]/android.widget.EditText")]
        protected IWebElement TN { get; set; }

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View[2]/android.view.View/android.view.View[2]/android.view.View[8]/android.view.View/android.view.View[1]")]
        protected IWebElement Emp { get; set; }



        [FindsBy(How = How.ClassName, Using = "android.widget.Button[2]")]
        protected IWebElement SignUp { get; set; }

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View[2]/android.view.View/android.view.View[2]/android.view.View/android.view.View[1]/android.widget.EditText")]
        protected IWebElement Username { get; set; }

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View[2]/android.view.View/android.view.View[3]/android.view.View/android.view.View[1]/android.widget.EditText")]
        protected IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "	/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View[2]/android.view.View/android.view.View[4]/android.view.View/android.view.View[1]/android.widget.EditText")]
        protected IWebElement ReTypePassword { get; set; }

        [FindsBy(How = How.ClassName, Using = "android.widget.Button")]
        protected IWebElement Enter { get; set; }


        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View[2]/android.view.View/android.view.View[3]/android.widget.Button")]
        protected IWebElement MobileLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[1]/android.view.View/android.view.View/android.view.View[3]/android.widget.EditText")]
        protected IWebElement EnterUsername { get; set; }

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[1]/android.view.View/android.view.View/android.view.View[4]/android.widget.EditText")]
        protected IWebElement EnterPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[1]/android.view.View/android.view.View/android.view.View[5]/android.widget.Button")]
        protected IWebElement ClickLogin { get; set; }

        


        public AppLoginPage(AndroidDriver<AndroidElement> driver)
        {
            driver = driver;
            PageFactory.InitElements(driver, this);
        }


        public void Signup()
        {
            SignUp.Click();
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
            Enter.Click();

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
            

        }

        public void MLogin()
        {
            EnterUsername.SendKeys(ConfigurationManager.AppSettings["MobileUsername"]);
            EnterPassword.SendKeys(ConfigurationManager.AppSettings["MobilePassword"]);
            ClickLogin.Click();
            System.Threading.Thread.Sleep(2000);

        }

    }
}
