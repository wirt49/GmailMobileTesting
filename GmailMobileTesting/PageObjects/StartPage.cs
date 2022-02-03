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
    public class StartPage: BasePage
    {
        public StartPage(AppiumDriver<AndroidElement>driver) : base(driver) { }

        [FindsBy(How = How.Id, Using = "welcome_tour_got_it")]
        private readonly AndroidElement gotItButton;

        public void ClickGotIt(int timeOut)
        {
            WaitVisibilityOfElement(timeOut, gotItButton);
            gotItButton.Click();
        }

    }
}
