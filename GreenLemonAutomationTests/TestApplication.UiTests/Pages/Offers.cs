﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.UiTests.Pages
{
    public class Offers
    {

        private readonly IWebDriver _driver;



        [FindsBy(How = How.XPath, Using = "//input[@class='Button Is_Default']")]
        protected IWebElement FindOffersButton { get; set; }

        

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Offers')]")]
        protected IWebElement ClickOffers { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Borrow £1,000 from Amigo Loans')]")]
        protected IWebElement Amigo { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Borrow £1,200 from Likely Loans')]")]
        protected IWebElement Likely { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Borrow £1,500 from UK Credit')]")]
        protected IWebElement Ukcredit { get; set; }


        public Offers(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }





        public void ClickonOffers()
        {

            ClickOffers.Click();
        }

        public void ClickonFindofferstome()
        {

            FindOffersButton.Click();
            System.Threading.Thread.Sleep(40000);
        }

        public void MyOffers()
        {
           
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            IWebElement NewOffers = wait.Until(d => d.FindElement(By.XPath("//div[@class='Title_Section']")));
            Assert.IsTrue(Amigo.Displayed);
            //Assert.IsTrue(Likely.Displayed);
            //Assert.IsTrue(Ukcredit.Displayed);
            



        }







    }
}