using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
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
    public class AppiumBase
    {
        public string userName = "nickhines2";
        public string accessKey = "yGGPyxUSGcB5MzsVoFqb";

        DesiredCapabilities caps = new DesiredCapabilities();

       public AndroidDriver<AndroidElement> driver;

        [SetUp]

        public void setup2()
        {
            caps.SetCapability("browserstack.user", userName);
            caps.SetCapability("browserstack.key", accessKey);
            caps.SetCapability("device", "Google Pixel");
            caps.SetCapability("os_version", "7.1");
            caps.SetCapability("app", "bs://afead7c3c7b20b76e26a5dd6c31e9b414905eb6d");
            driver = new AndroidDriver<AndroidElement>(new Uri("http://hub-cloud.browserstack.com/wd/hub"), caps);
            

            //driver.FindElement(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.webkit.WebView/android.webkit.WebView/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View/android.view.View[2]/android.view.View[2]/android.view.View/android.view.View[2]/android.widget.Button")).Click();
            System.Threading.Thread.Sleep(10000);
            

        }

    }
}
