using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.UiTests.Utils
{
    public class BaseAppium
    {

        //public static RemoteWebDriver driver;

       public static AppiumDriver<IWebElement> driver;

        // Your username and authkey here
        //public string username = "siva.arunagiri@greenlemoncompany.net";
        //public string authkey = "u9773ac8866b6fba";

        //public string username = "siva454";
        //public string authkey = "b1az5z4YK9SKiMexsxBU";

        //readonly static string userName = "siva454";
        //readonly static string accessKey = "b1az5z4YK9SKiMexsxBU";

       public string userName = "siva454";
       public string accessKey = "b1az5z4YK9SKiMexsxBU";

        DesiredCapabilities caps = new DesiredCapabilities();


        [SetUp]
        public void SetUp()
        {

            //caps.SetCapability("deviceName", "donatello");
            //caps.SetCapability("Apppackage", "come.example.calculator");

            caps.SetCapability("browserstack.user", userName);
            caps.SetCapability("browserstack.key", accessKey);
            caps.SetCapability("device", "Google Pixel");
            caps.SetCapability("os_version", "7.1");
            caps.SetCapability("app", "bs://1a845731528d99f5e9fd4fde0441646e05308b54");

            AndroidDriver<AndroidElement> driver = new AndroidDriver<AndroidElement>(new Uri("http://hub-cloud.browserstack.com/wd/hub"), caps);
           

            //Launch Andriod browser




            //Browserstack

            //caps.SetCapability("browser", "Chrome");
            //caps.SetCapability("browser_version", "62.0");
            //caps.SetCapability("os", "Windows");
            //caps.SetCapability("os_version", "10");
            //caps.SetCapability("resolution", "1024x768");
            //caps.SetCapability("browserstack.user", username);
            //caps.SetCapability("browserstack.key", authkey);



            //Cross Browsing tests
            //caps.SetCapability("name", "CustomerVue PrePost Tests");
            //caps.SetCapability("record_video", "true");
            //caps.SetCapability("build", "1.35");

            ////Chrome
            //caps.SetCapability("browserName", "Chrome");
            //caps.SetCapability("version", "69x64");
            //caps.SetCapability("platform", "Windows 10");
            //caps.SetCapability("screenResolution", "1366x768");



            //caps.SetCapability("record_video", "true");
            //caps.SetCapability("record_network", "true");

            ////caps.SetCapability("username", username);
            ////caps.SetCapability("password", authkey);
            ////driver = driver = new RemoteWebDriver(new Uri("http://hub-cloud.browserstack.com/wd/hub/"), caps, TimeSpan.FromSeconds(180));

            //caps.SetCapability("username", username);
            //caps.SetCapability("password", authkey);
            //driver = driver = new RemoteWebDriver(new Uri("http://hub.crossbrowsertesting.com:80/wd/hub"), caps, TimeSpan.FromSeconds(180));
            //driver.Manage().Window.Maximize();

        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
