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
    public class HomePage: BasePage
    {

        [FindsBy(How = How.Id, Using = "gm_dismiss_button")]
        private AndroidElement dismissButton;

        [FindsBy(How = How.Id, Using = "compose_button")]
        private AndroidElement composeButton;

        [FindsBy(How = How.XPath, Using = "//android.widget.ImageButton[@content-desc='Open navigation drawer']")]
        private AndroidElement toolBarButton;

        [FindsBy(How = How.XPath, Using = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.support.v4.widget.DrawerLayout/android.widget.FrameLayout[2]/android.widget.ListView/android.widget.LinearLayout[9]/android.widget.ImageView")]
        private AndroidElement sentMesseges;

        public HomePage(AppiumDriver<AndroidElement> driver) : base(driver) { }
        
        public void ClickDismiss(int timeOut)
        {
            WaitVisibilityOfElement(timeOut, dismissButton);
            dismissButton.Click();
        }

        public void ClickCompose(int timeOut)
        {
            WaitVisibilityOfElement(timeOut, composeButton);
            composeButton.Click();
        }


        public void ClickToolBar()
        {
            toolBarButton.Click();
        }

        public void ClickSent(int timeOut)
        {
            WaitVisibilityOfElement(timeOut, sentMesseges);
            sentMesseges.Click();
        }

    }
}
