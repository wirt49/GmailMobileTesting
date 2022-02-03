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
    public class MessegePage:BasePage
    {
        public MessegePage(AppiumDriver<AndroidElement> driver) : base(driver) { }


        [FindsBy(How = How.Id, Using = "to")]
        private AndroidElement adressTextField;

        [FindsBy(How = How.Id, Using = "subject")]
        private AndroidElement subjectTextField;

        [FindsBy(How = How.Id, Using = "send")]
        private AndroidElement sendMessegeButton;

        public void InputAdress(string adress)
        {
            adressTextField.SendKeys(adress);
            driver.HideKeyboard();
        }

        public void InputSubject(string subject)
        {
            subjectTextField.Click();
            subjectTextField.SendKeys(subject);
            driver.HideKeyboard();
        }

        public void ClickSendMessege(int timeOut)
        {
            sendMessegeButton.Click();
        }

    }
}
