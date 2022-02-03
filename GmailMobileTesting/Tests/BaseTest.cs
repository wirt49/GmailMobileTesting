using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailMobileTesting.Tests
{
    [TestFixture]
    public class BaseTest
    {

        AppiumDriver<AndroidElement> driver;

        public AppiumDriver<AndroidElement> Driver
        {
            get
            {
                return driver;
            }
        }

        [SetUp]
        public void Setup()
        {
            var cap = new AppiumOptions();
            cap.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            cap.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Pixel2");
            cap.AddAdditionalCapability(MobileCapabilityType.Udid, "emulator-5554");
            cap.AddAdditionalCapability(AndroidMobileCapabilityType.AppActivity, "com.google.android.gm.GmailActivity");
            cap.AddAdditionalCapability(AndroidMobileCapabilityType.AppPackage, "com.google.android.gm");
            driver = new AndroidDriver<AndroidElement>(new Uri("http://localhost:4724/wd/hub"), cap);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
