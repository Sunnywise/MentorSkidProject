using MentorSkidSoftwareProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MentorSkidSoftwareProject.PageObject
{
    public class AboutUsPage
    {
        public IWebDriver driver;
        public AboutUsPage()
        {
            driver=BaseTest.driver;
        }

        private By abtUs = By.CssSelector("#menu-item-1989");
        private By imagePix = By.XPath("//img[@alt='STEP 1']");


        public void NavigateToMentorskidWebsite()
        {
            driver.Navigate().GoToUrl("https://mentorskid.com");
           
        }
        public void ClickOnAboutUs()
        {
            driver.FindElement(abtUs).Click();
        }

        public bool DirectedToAboutUsPage()
        {
            return driver.Url.Contains("https://mentorskid.com/how-it-work/");
        }

        public bool ScrollToSecondSection()
        {
            Thread.Sleep(5000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,670)");
            return driver.FindElement(imagePix).Displayed;

        }

        public bool ScrollToThirdSection()
        {
            Thread.Sleep(5000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,1000)");
            Thread.Sleep(5000);
            return driver.Url.Contains("https://mentorskid.com/how-it-work/");
        }

    }
}
