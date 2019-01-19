using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.UiTests.Pages
{
    public class MobileLoginPage
    {

        [FindsBy(How = How.Id, Using = "ctl00_cp_lblVersionNo")]
        protected IWebElement VersionNumber { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'+44 3333 443 654')]")]
        protected IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cp_Login_UserName")]
        protected IWebElement LoginUsername { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cp_Login_Password")]
        protected IWebElement LoginPassword { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cp_Login_LoginButton")]
        protected IWebElement LoginBtn { get; set; }

        private readonly IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Username (Confirm e-mail address)']")]
        protected IWebElement Username { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Password']")]
        protected IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Re-type Password']")]
        protected IWebElement ReTypePassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        protected IWebElement Enter { get; set; }

        public MobileLoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }


        public String VersionNumberText()
        {
            return VersionNumber.Text.ToLower();
        }

        public String PhoneNumberText()
        {
            return PhoneNumber.Text.ToLower();
        }

        public Boolean VersionNoDisplays()
        {

            return VersionNumber.Displayed;
        }

        public Boolean PhoneNoDisplays()
        {

            return PhoneNumber.Displayed;
        }

        public void LoginAs(String user, String passwd)
        {
            LoginUsername.SendKeys(user);
            LoginPassword.SendKeys(passwd);
            LoginBtn.Click();

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
    }
}
