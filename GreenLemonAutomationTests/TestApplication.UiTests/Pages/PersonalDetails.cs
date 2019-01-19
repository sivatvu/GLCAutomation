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

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Mr.')]")]
        protected IWebElement Title { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='First Name']")]
        protected IWebElement FN { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Surname']")]
        protected IWebElement SN{ get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Date of Birth']")]
        protected IWebElement DOB { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Telephone number']")]
        protected IWebElement TN { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Self Employed')]")]
        protected IWebElement Emp { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Homeowner')]")]
        protected IWebElement ResD { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='submit' and @value='Enter']")]
        protected IWebElement EnterPersonalDetails { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox'][1]")]
        protected IWebElement Agreed { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='House/Flat number (optional)']")]
        protected IWebElement House { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Postcode']")]
        protected IWebElement PostCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Month']")]
        protected IWebElement MonthMovedIn { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Year']")]
        protected IWebElement YearMovedin { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Gross annual income (£)']")]
        protected IWebElement Gross { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Enter your personal details')]")]
        protected IWebElement PersonalDetailsPage { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='submit' and @value='Address Search']")]
        protected IWebElement AddressSearchButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='submit' and @value='Add Address']")]
        protected IWebElement AddAddressButton { get; set; }






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

        }


    }
}
