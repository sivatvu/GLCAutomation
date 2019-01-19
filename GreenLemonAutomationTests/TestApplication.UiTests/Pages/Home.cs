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
    public class Home
    {

        private readonly IWebDriver _driver;

       

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Credit score')]")]
        protected IWebElement CreditScore { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Offers')]")]
        protected IWebElement Offers { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'ChatFlows')]")]
        protected IWebElement ChatFlows { get; set; }


        public Home(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }





        public Boolean CreditscoreDisplays()
        {

            return CreditScore.Displayed;
        }

        public Boolean OffersDisplays()
        {

            return Offers.Displayed;
        }

        public Boolean ChatFlowsDisplays()
        {

            return ChatFlows.Displayed;
            System.Threading.Thread.Sleep(500);
        }





    }
}
