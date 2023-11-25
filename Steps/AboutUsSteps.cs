using MentorSkidSoftwareProject.Hooks;
using MentorSkidSoftwareProject.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace MentorSkidSoftwareProject.Steps
{
    [Binding]
    public class AboutUsSteps
    {
        public IWebDriver driver = BaseTest.driver;
        AboutUsPage aboutUsPage = new AboutUsPage();

        [Given(@"that I am a user of mentorskid website")]
        public void GivenThatIAmAUserOfMentorskidWebsite()
        {
            aboutUsPage.NavigateToMentorskidWebsite();
        }
        
        [When(@"I click on the About us tab from the Menu")]
        public void WhenIClickOnTheAboutUsTabFromTheMenu()
        {
            aboutUsPage.ClickOnAboutUs();
        }
        
        [Then(@"I am directed to the About us page")]
        public void ThenIAmDirectedToTheAboutUsPage()
        {
            Assert.IsTrue(driver.Url.Contains("https://mentorskid.com/how-it-work/"));
        }
        
        [Then(@"I scroll to the second section: How it works")]
        public void ThenIScrollToTheSecondSectionHowItWorks()
        {
            Assert.IsTrue(aboutUsPage.ScrollToSecondSection());
        }
        
        [Then(@"I scroll to the third section: Call to action")]
        public void ThenIScrollToTheThirdSectionCallToAction()
        {
            aboutUsPage.ScrollToThirdSection();
            Assert.IsTrue(driver.Url.Contains("https://mentorskid.com/how-it-work/"));
        }
    }
}
