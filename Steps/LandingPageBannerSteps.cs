using MentorSkidSoftwareProject.Hooks;
using MentorSkidSoftwareProject.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MentorSkidSoftwareProject.Features
{
    [Binding]
    public class LandingPageBannerSteps
    {
        public static IWebDriver driver = BaseTest.driver;
        LandingPageBannerPage _landingPageBannerPage = new LandingPageBannerPage();

        [Given(@"that I am a user of ""(.*)""")]
        public void GivenThatIAmAUserOf(string Url)
        {
            _landingPageBannerPage.NavigateToUrl(Url);
        }

        [When(@"I click on the Start as a Mentee button")]
        public void WhenIClickOnTheStartAsAMenteeButton()
        {
            _landingPageBannerPage.MenteeClickButtonAsStart();
        }

        [Then(@"I must be directed to the Registration Page")]
        public void ThenIMustBeDirectedToTheRegistrationPage()
        {
           _landingPageBannerPage.MenteeRegistrationPage();
           
        }

        [When(@"I click on the Join as a Mentor button")]
        public void WhenIClickOnTheJoinAsAMentorButton()
        {
            _landingPageBannerPage.MentorClickJoinAsMentor();
        }

        [Then(@"I must be directed to the Registration Page again")]
        public void ThenIMustBeDirectedToTheRegistrationPageAgain()
        {
            Assert.IsTrue(driver.Url.Contains("https://mentorskid.com/signup/"));
        }
    }
}
