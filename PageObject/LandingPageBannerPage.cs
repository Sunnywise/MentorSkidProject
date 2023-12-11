using MentorSkidSoftwareProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MentorSkidSoftwareProject.PageObject
{
    public class LandingPageBannerPage
    {
        public static IWebDriver driver;
        public LandingPageBannerPage()
        {
            driver = BaseTest.driver;
        }
        private By startAsMentee = By.XPath("//span[normalize-space()='Start as a Mentee']");
        private By joinAsMentor = By.XPath("//span[normalize-space()='Join as a Mentor']");
       
        public void NavigateToUrl(string Url)
        {
            driver.Navigate().GoToUrl(Url);
        }

        public void MenteeClickButtonAsStart()
        {
            driver.FindElement(startAsMentee).Click();
        }

        public void MentorClickJoinAsMentor()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElement(joinAsMentor).Click();
        }

        public void MenteeRegistrationPage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Navigate().Back();
           driver.Url = "https://mentorskid.com";
        }

        public bool MentorRegistrationPage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            return driver.Url.Contains("https://mentorskid.com/signup/");          
        }

    }
}
