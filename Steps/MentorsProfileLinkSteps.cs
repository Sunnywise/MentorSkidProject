using MentorSkidSoftwareProject.Hooks;
using MentorSkidSoftwareProject.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MentorSkidSoftwareProject.Features
{
    [Binding]
    public class MentorsProfileLinkSteps
    {
        public IWebDriver driver = BaseTest.driver;
        MentorsProfileLinkPage _mentorsProfileLinkPage = new MentorsProfileLinkPage();


        [Given(@"that I am a user of mentor skid webpage")]
        public void GivenThatIAmAUserOfMentorSkidWebpage()
        {
            driver.Navigate().GoToUrl(@"https://mentorskid.com/");
        }
        
        [When(@"I click on Find a mentor button")]
        public void WhenIClickOnFindAMentorButton()
        {
            _mentorsProfileLinkPage.ClickFindAMentor();
        }
        
        [When(@"I click on View profile button of any of the mentors")]
        public void WhenIClickOnViewProfileButtonOfAnyOfTheMentors()
        {
            _mentorsProfileLinkPage.ClickViewProfile();
        }
        
        [When(@"I click on the mentor's profile link")]
        public void WhenIClickOnTheMentorSProfileLink()
        {
            _mentorsProfileLinkPage.ClickUrlLink();
        }
        
        [Then(@"I must be directed to the Mentor's profile page on another tab successfully")]
        public void ThenIMustBeDirectedToTheMentorSProfilePageOnAnotherTabSuccessfully()
        {
            Assert.IsTrue(_mentorsProfileLinkPage.AssertLogo());
        }
    }
}
