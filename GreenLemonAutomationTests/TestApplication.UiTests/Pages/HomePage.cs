using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.UiTests.Pages
{
    class Demo1
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

        public Demo1(IWebDriver driver)
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

        public Demo2 LoginAs(String user, String passwd)
        {
            LoginUsername.SendKeys(user);
            LoginPassword.SendKeys(passwd);
            LoginBtn.Click();

            return new Demo2(_driver);
        }

    }
}
