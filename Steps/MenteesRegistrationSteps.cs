using MentorSkidSoftwareProject.Hooks;
using MentorSkidSoftwareProject.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MentorSkidSoftwareProject.Features
{
    [Binding]
    public class MenteesRegistrationSteps
    {
        public static IWebDriver driver = BaseTest.driver;
        MenteesRegistrationPage _menteesRegistrationPage = new MenteesRegistrationPage();

        [Given(@"that I am a user of https://mentorskid\.com/")]
        public void GivenThatIAmAUserOfHttpsMentorskid_Com()
        {
            driver.Navigate().GoToUrl(@"https://mentorskid.com/");
        }
        
        [When(@"I click on the start as a Mentee's button on the homepage banner")]
        public void WhenIClickOnTheStartAsAMenteeSButtonOnTheHomepageBanner()
        {
            _menteesRegistrationPage.UserClickOnStartMentee();
        }
        
        [When(@"I enter first name ""(.*)""")]
        public void WhenIEnterFirstName(string p0)
        {
            _menteesRegistrationPage.UserEntersFirstName(p0);
        }
        
        [When(@"I enter last name ""(.*)""")]
        public void WhenIEnterLastName(string p0)
        {
            _menteesRegistrationPage.UserEntersLastName(p0);
        }
        
        [When(@"I enter my email address in the email field as ""(.*)""")]
        public void WhenIEnterMyEmailAddressInTheEmailFieldAs(string p0)
        {
            _menteesRegistrationPage.UserEntersEmailAddress(p0);
        }
        
        [When(@"I enter password of my choice as ""(.*)""")]
        public void WhenIEnterPasswordOfMyChoiceAs(string p0)
        {
            _menteesRegistrationPage.UserEntersPassword(p0);
        }
        
        [When(@"I click on Mentee radio button")]
        public void WhenIClickOnMenteeRadioButton()
        {
            _menteesRegistrationPage.UserClickOnStudentMentee();
        }

        [When(@"I click on the terms and conditions checkbox")]
        public void WhenIClickOnTheTermsAndConditionsCheckbox()
        {
            _menteesRegistrationPage.TermsAndConditions();
        }
        
        [When(@"I click on the ""(.*)"" button")]
        public void WhenIClickOnTheButton(string p0)
        {
            _menteesRegistrationPage.UserEntersJoinNowButton();
        }
        
        [Then(@"the text ""(.*)"" is displayed as popups")]
        public void ThenTheTextIsDisplayedAsPopups(string Text)
        {
            _menteesRegistrationPage.OopsMessageIsDisplayed().Contains("Password must be 8 characters");
        }

        [Then(@"the registered page for Mentee is displayed")]
        public void ThenTheRegisteredPageForMenteeIsDisplayed()
        {
            Assert.IsTrue(_menteesRegistrationPage.RegisteredLoginPage());
        }

    }
}
