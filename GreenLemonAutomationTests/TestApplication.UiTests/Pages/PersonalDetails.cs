using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace TestApplication.UiTests.Pages
{
    public class PersonalDetails
    {

        [FindsBy(How = How.XPath, Using = "//div[text()='Mr']")]
        protected IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'FirstName')]")]
        protected IWebElement FN { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'Surname')]")]
        protected IWebElement SN{ get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'DateOfBirth')]")]
        protected IWebElement DOB { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'TelephoneNumber')]")]
        protected IWebElement TN { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[text()='Self Employed']")]
        protected IWebElement Emp { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[text()='Homeowner']")]
        protected IWebElement ResD { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='submit' and @value='Next']")]
        protected IWebElement EnterPersonalDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox' and @class='bigcheck']")]
        protected IWebElement Agreed { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'AddressFlatNumber')]")]
        protected IWebElement House { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'AddressPostcode')]")]
        protected IWebElement PostCode { get; set; }



        [FindsBy(How = How.XPath, Using = "//select[contains(@id, 'Month')]")]
        protected IWebElement MonthMovedIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'Year')]")]
        protected IWebElement YearMovedin { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@id, 'Gross')]")]
        protected IWebElement Gross { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'We just need a few details ')]")]
        protected IWebElement PersonalDetailsPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='submit' and @value='Find my address']")]
        protected IWebElement AddressSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='submit' and @value='Add Address']")]
        protected IWebElement AddAddressButton { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'IDVERIFIER ST1 , ELY, CB6 2AG')]")]
        protected IWebElement SelectAddress { get; set; }





        private IWebDriver _driver;


        public PersonalDetails(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        
        public void SelectTitle()
        {
            Title.Click();

        }

        public void FirstN(string FirstName)
        {
            FN.SendKeys(FirstName);



        }
        public void SecondN(string SurName)
        {

            SN.SendKeys(SurName);




        }
        public void DateOB(string DateOfBirth)
        {

            DOB.SendKeys(DateOfBirth);



        }
        public void Tele(string TelephoneNumber)
        {

            TN.SendKeys(TelephoneNumber);


        }

        public void AgreeTermsandConditions()
        {

            Agreed.Click();
        }

        public void GrossAnnual(string GrossAnnualIncome)
        {

            Gross.SendKeys(GrossAnnualIncome);
        }



        public void SelectEmploymentandResidential()
        {
            Emp.Click();
            ResD.Click();

        }

        public void EnterPD()
        {

            EnterPersonalDetails.Click();
            System.Threading.Thread.Sleep(10000);
        }

        public void Address()
        {
            House.SendKeys(ConfigurationManager.AppSettings["House"]);
            PostCode.SendKeys(ConfigurationManager.AppSettings["PCode"]);
           
        }

        public void MovedInDates()
        {
            
            MonthMovedIn.SendKeys(ConfigurationManager.AppSettings["Month"]);
            YearMovedin.SendKeys(ConfigurationManager.AppSettings["Year"]);
        }

        public Boolean PersonalDetailDisplays()
        {

            return PersonalDetailsPage.Displayed;
        }

        //public class Account
        //{
        //    public string FirstName { get; set; }
        //    public string FirstName { get; set; }
        //    public string FirstName { get; set; }
        //    public string FirstName { get; set; }
        //    public string FirstName { get; set; }

        //}


        public void AddressSearch()
        {
            AddressSearchButton.Click();
            System.Threading.Thread.Sleep(10000);

        }

        public void AddAddress()
        {
            AddAddressButton.Click();
            System.Threading.Thread.Sleep(2000);

        }

        public void SelectspecificAddress()
        {
            SelectAddress.Click();
            System.Threading.Thread.Sleep(2000);

        }


    }
}
