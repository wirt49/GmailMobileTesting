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

namespace GmailMobileTesting.PageObjects
{
    public class TakeToGmailPage: BasePage
    {
        public TakeToGmailPage(AppiumDriver<AndroidElement> driver) : base(driver) { }

        [FindsBy(How = How.Id, Using = "action_done")]
        private readonly AndroidElement takeMeToGmailButton;

        public void ClickTakeMeTo(int timeOut)
        {
            WaitVisibilityOfElement(timeOut, takeMeToGmailButton);
            takeMeToGmailButton.Click();
        }
    }
}
