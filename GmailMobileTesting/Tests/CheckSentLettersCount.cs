using NUnit.Framework;
using Appium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using System;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.MultiTouch;
using System.Threading;
using GmailMobileTesting.Tests;

namespace GmailMobileTesting
{
    public class CheckSentLettersCount : BaseTest
    {



        [Test]
        public void CheckSentLetterCount()
        {
            var gotitButton = Driver.FindElementById("welcome_tour_got_it");
            gotitButton.Click();
            var goToGmail = Driver.FindElementById("action_done");
            goToGmail.Click();

            var dismissButton = Driver.FindElementById("gm_dismiss_button");
            dismissButton.Click();

            var dismissButton2 = Driver.FindElementById("gm_dismiss_button");
            dismissButton2.Click();


            var composeButton = Driver.FindElementById("compose_button");
            composeButton.Click();

            Driver.HideKeyboard();
            var adressLetter = Driver.FindElementById("to");
            adressLetter.SendKeys("wirtandrew49@gmail.com");
            Driver.HideKeyboard();
            var subject = Driver.FindElementById("subject");
            subject.Click();
            subject.SendKeys("mobile");



            var sendButton = Driver.FindElementById("send");
            sendButton.Click();

            var toolBarButton = Driver.FindElementByXPath("//android.widget.ImageButton[@content-desc='Open navigation drawer']");
            toolBarButton.Click();

            var pathSent = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.support.v4.widget.DrawerLayout/android.widget.FrameLayout[2]/android.widget.ListView/android.widget.LinearLayout[9]/android.widget.ImageView";
            var sent = Driver.FindElementByXPath(pathSent);
            sent.Click();

            var path = "//android.view.View[@content-desc='Select this conversation']";
            int sentLettersCount = Driver.FindElementsByXPath(path).Count;
            Assert.AreEqual(1, sentLettersCount);
        }
    }
}