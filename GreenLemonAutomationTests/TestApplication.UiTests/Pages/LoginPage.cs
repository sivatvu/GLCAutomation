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
    public class LoginPage
    {

        [FindsBy(How = How.XPath, Using = "//div[@class='Heading1' and text()='Create Password']")]
        protected IWebElement CreateAccountPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'+44 3333 443 654')]")]
        protected IWebElement PhoneNumber { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cp_Login_UserName")]
        protected IWebElement LoginUsername { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cp_Login_Password")]
        protected IWebElement LoginPassword { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cp_Login_LoginButton")]
        protected IWebElement LoginBtn { get; set; }

        private readonly IWebDriver _driver;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='E-mail']")]
        protected IWebElement Username { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Password']")]
        protected IWebElement Password { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Re-type Password']")]
        protected IWebElement ReTypePassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        protected IWebElement Enter { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='WebPatterns_wt1_block_wtUsername_wtUserNameInput']")]
        protected IWebElement WebUsername { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='WebPatterns_wt1_block_wtPassword_wtPasswordInput']")]
        protected IWebElement WebPassword { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='WebPatterns_wt1_block_wtAction_wtLoginButton']")]
        protected IWebElement WebLoginButton { get; set; }


        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }


       
      

        public Boolean CreateAccountDisplays()
        {

            return CreateAccountPage.Displayed;
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

        public void WebLogin()
        {
            WebUsername.SendKeys(ConfigurationManager.AppSettings["WebUsername"]);
            WebPassword.SendKeys(ConfigurationManager.AppSettings["WebPassword"]);
            WebLoginButton.Click();

        }




        public void EnterLogin()
        {
          
            Enter.Click();
            System.Threading.Thread.Sleep(1000);



        }
    }
}
