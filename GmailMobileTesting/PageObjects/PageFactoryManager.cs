using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GmailMobileTesting.PageObjects
{
    public class PageFactoryManager
    {
        public AppiumDriver<AndroidElement> driver;

        public PageFactoryManager(AppiumDriver<AndroidElement> driver)
        {
            this.driver = driver;
        }

        public HomePage GetHomePage(AppiumDriver<AndroidElement> driver) => new HomePage(driver);

        public StartPage GetStartPage(AppiumDriver<AndroidElement> driver) => new StartPage(driver);

        public TakeToGmailPage GetTakeToGmailPage(AppiumDriver<AndroidElement> driver) => new TakeToGmailPage(driver);

        public MessegePage GetMessegePage(AppiumDriver<AndroidElement> driver) => new MessegePage(driver);

        public SentMessegesPage GetSentMessegesPage(AppiumDriver<AndroidElement> driver) => new SentMessegesPage(driver);


    }
}
