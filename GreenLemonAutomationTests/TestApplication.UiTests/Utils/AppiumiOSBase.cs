using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.UiTests.Utils
{
    public class AppiumiOSBase
    {
        public string userName = "nickhines2";
        public string accessKey = "yGGPyxUSGcB5MzsVoFqb";

        DesiredCapabilities caps = new DesiredCapabilities();

        //public AndroidDriver<AndroidElement> driver;
        public IOSDriver<IOSElement> driver;

        [SetUp]

        public void setupiOS()
        {
            caps.SetCapability("browserstack.user", userName);
            caps.SetCapability("browserstack.key", accessKey);
            caps.SetCapability("device", "iPhone 7");
            //caps.SetCapability("os_version", "7.1");
            caps.SetCapability("app", "bs://38e8e191acdcae20f9d539cd30c864e2109cf613");
            //driver = new AndroidDriver<AndroidElement>(new Uri("http://hub-cloud.browserstack.com/wd/hub"), caps);
            driver = new IOSDriver<IOSElement>(new Uri("http://hub-cloud.browserstack.com/wd/hub"), caps);


            //driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View[2]/android.view.View/android.view.View[2]/android.widget.Button")).Click();
            System.Threading.Thread.Sleep(10000);


        }

    }
}
