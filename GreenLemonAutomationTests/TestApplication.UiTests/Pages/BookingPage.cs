using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestApplication.UiTests.Pages
{
    class Demo2
    {
        private IWebDriver _driver;

        public Demo2(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
    }
}
