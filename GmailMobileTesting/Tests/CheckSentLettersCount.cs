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
using GmailMobileTesting.PageObjects;

namespace GmailMobileTesting
{
    public class CheckSentLettersCount : BaseTest
    {
        private readonly int timeoutInSeconds = 100;
        private readonly string adress = "wirtandrew49@gmail.com";
        private readonly string subject = "mobile";

        [Test]
        public void Check()
        {
            PageFactoryManager pageFactoryManager = new PageFactoryManager(Driver);
            HomePage homePage = pageFactoryManager.GetHomePage(Driver);
            MessegePage messegePage = pageFactoryManager.GetMessegePage(Driver);
            SentMessegesPage sentMessegesPage = pageFactoryManager.GetSentMessegesPage(Driver);
            StartPage startPage = pageFactoryManager.GetStartPage(Driver);
            TakeToGmailPage takeToGmailPage = pageFactoryManager.GetTakeToGmailPage(Driver);

            startPage.ClickGotIt(timeoutInSeconds);

            takeToGmailPage.ClickTakeMeTo(timeoutInSeconds);

            homePage.ClickDismiss(timeoutInSeconds);
            homePage.ClickDismiss(timeoutInSeconds);
            homePage.ClickCompose(timeoutInSeconds);

            messegePage.InputAdress(adress);
            messegePage.InputSubject(subject);
            messegePage.ClickSendMessege(timeoutInSeconds);

            homePage.ClickToolBar();
            homePage.ClickSent(timeoutInSeconds);

            int sentMessegesCount = sentMessegesPage.GetSentMessegesCount();
            Assert.AreEqual(1, sentMessegesCount);
        }

        //[Test]
        //public void CheckSentLetterCount()
        //{
        //    var gotitButton = Driver.FindElementById("welcome_tour_got_it");
        //    gotitButton.Click();
        //    var goToGmail = Driver.FindElementById("action_done");
        //    goToGmail.Click();

        //    var dismissButton = Driver.FindElementById("gm_dismiss_button");
        //    dismissButton.Click();

        //    var dismissButton2 = Driver.FindElementById("gm_dismiss_button");
        //    dismissButton2.Click();


        //    var composeButton = Driver.FindElementById("compose_button");
        //    composeButton.Click();

        //    Driver.HideKeyboard();
        //    var adressLetter = Driver.FindElementById("to");
        //    adressLetter.SendKeys("wirtandrew49@gmail.com");
        //    Driver.HideKeyboard();
        //    var subject = Driver.FindElementById("subject");
        //    subject.Click();
        //    subject.SendKeys("mobile");



        //    var sendButton = Driver.FindElementById("send");
        //    sendButton.Click();

        //    var toolBarButton = Driver.FindElementByXPath("//android.widget.ImageButton[@content-desc='Open navigation drawer']");
        //    toolBarButton.Click();

        //    var pathSent = "/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.support.v4.widget.DrawerLayout/android.widget.FrameLayout[2]/android.widget.ListView/android.widget.LinearLayout[9]/android.widget.ImageView";
        //    var sent = Driver.FindElementByXPath(pathSent);
        //    sent.Click();

        //    var path = "//android.view.View[@content-desc='Select this conversation']";
        //    int sentLettersCount = Driver.FindElementsByXPath(path).Count;
        //    Assert.AreEqual(1, sentLettersCount);
        //}
    }
}