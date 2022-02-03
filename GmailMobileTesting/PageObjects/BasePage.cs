using NUnit.Framework;
using Appium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.MultiTouch;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;

namespace GmailMobileTesting.PageObjects
{
    public class BasePage
    {
        protected AppiumDriver<AndroidElement> driver;

        public BasePage(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
        }


        public void WaitVisibilityOfElement(int timeout, AndroidElement element)
        {
            // wait element clickability
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }
    }
}
