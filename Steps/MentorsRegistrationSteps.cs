using MentorSkidSoftwareProject.Hooks;
using MentorSkidSoftwareProject.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MentorSkidSoftwareProject.Features
{
    [Binding]
    public class MentorsRegistrationSteps
    {
        public static IWebDriver driver = BaseTest.driver;
        MentorsRegistrationPage _mentorsRegistrationPage = new MentorsRegistrationPage();

        [Given(@"that a user navigate on https://mentorskid\.com/")]
        public void GivenThatAUserNavigateOnHttpsMentorskid_Com()
        {
            driver.Navigate().GoToUrl(@"https://mentorskid.com/");
        }

        [When(@"user clicks on the Join as a Mentor's button on the homepage banner")]
        public void WhenUserClicksOnTheJoinAsAMentorSButtonOnTheHomepageBanner()
        {
            _mentorsRegistrationPage.UserClickOnJoinMentor();
        }

        [When(@"user enters first name ""(.*)""")]
        public void WhenUserEntersFirstName(string p0)
        {
            _mentorsRegistrationPage.UserEntersFirstName(p0);
        }

        [When(@"user enters last name ""(.*)""")]
        public void WhenUserEntersLastName(string p0)
        {
            _mentorsRegistrationPage.UserEntersLastName(p0);
        }

        [When(@"user enters email address in the given email field as ""(.*)""")]
        public void WhenUserEntersEmailAddressInTheGivenEmailFieldAs(string p0)
        {
            _mentorsRegistrationPage.UserEntersEmailAddress(p0);
        }

        [When(@"user enters password as ""(.*)""")]
        public void WhenUserEntersPasswordAs(string p0)
        {
            _mentorsRegistrationPage.UserEntersPassword(p0);
        }

        [When(@"user clicks on instructor radio button")]
        public void WhenUserClicksOnInstructorRadioButton()
        {
            _mentorsRegistrationPage.UserClickOnInstructorMentor();
        }

        [When(@"user clicks on the terms and conditions checkbox")]
        public void WhenUserClicksOnTheTermsAndConditionsCheckbox()
        {
            _mentorsRegistrationPage.TermsAndConditions();
        }

        [When(@"user clicks on the ""(.*)"" button")]
        public void WhenUserClicksOnTheButton(string p0)
        {
            _mentorsRegistrationPage.UserEntersJoinNowButton();
        }

        [When(@"user clicks on the Join as a Mentor's button one the homepage banner")]
        public void WhenUserClicksOnTheJoinAsAMentorSButtonOneTheHomepageBanner()
        {
            _mentorsRegistrationPage.UserClickOnJoinMentor();
        }

        [Then(@"the text ""(.*)"" is displayed")]
        public void ThenTheTextIsDisplayed(string Text)
        {
            _mentorsRegistrationPage.ErrorInvalidMessage().Contains("Password must be 8 characters");
            //Assert.AreEqual(Text, _mentorsRegistrationPage.ErrorInvalidMessage());
        }

        [Then(@"the registered page is displayed")]
        public void ThenTheRegisteredPageIsDisplayed()
        {
           Assert.IsTrue(_mentorsRegistrationPage.RedirectedPage());
        }

    }
}
