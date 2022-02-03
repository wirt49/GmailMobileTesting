using NUnit.Framework;
using Appium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.MultiTouch;
using System.Threading;
using OpenQA.Selenium.Support.PageObjects;
using System.Linq;

namespace GmailMobileTesting.PageObjects
{
    public class SentMessegesPage:BasePage
    {
        public SentMessegesPage(AppiumDriver<AndroidElement> driver) : base(driver) { }

        public string path = "//android.view.View[@content-desc='Select this conversation']";
        

        public int GetSentMessegesCount()
        {
            return driver.FindElementsByXPath(path).Count();
        }
        
    }
}
