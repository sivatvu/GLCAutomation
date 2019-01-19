//using System;
//using TechTalk.SpecFlow;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Remote;
//using System.Configuration;
//using OpenQA.Selenium.Support.UI;
//using System.Collections.ObjectModel;
//using System.Net;
//using System.IO;
//using System.Text.RegularExpressions;
//using System.Text;
//using TestApplication.UiTests.Utils;
//using TestApplication.UiTests.Pages;
//using System.Linq;
//using TechTalk.SpecFlow.Assist;
//using static TestApplication.UiTests.Pages.PersonalDetails;

//namespace CBT_Example_26
//{

//    [Binding]
//    public class TestData
//    {
       

//        [Given(@"I generate Test Data")]
//        public void GivenIGenerateTestData()
//        {
//            string fullName = Faker.Name.FullName();
//            string firstName = Faker.Name.First();
//            string lastName = Faker.Name.Last();
//            string address = Faker.Address.City();
//            string phoneNumber = Faker.Phone.Number();
//            string email = Faker.Internet.Email();

//            Console.WriteLine("The FullName is: " + fullName);
//            Console.WriteLine("The FirstName is: " + firstName);
//            Console.WriteLine("The LastName is: " + lastName);
//            Console.WriteLine("The Address is: " + address);
//            Console.WriteLine("The Email is: " + email);
//            Console.WriteLine("The PhoneNumber is: " + fullName);

//        }












//    }
//}
