using MentorSkidSoftwareProject.Hooks;
using MentorSkidSoftwareProject.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MentorSkidSoftwareProject.Features
{
    [Binding]
    public class AvailabilityDaysFilterSteps
    {
        public IWebDriver driver = BaseTest.driver;
        AvailabilityDaysFilterPage _availabilityDaysFilterPage = new AvailabilityDaysFilterPage();

        [Given(@"that I am a registered mentee on mentorskid's webpage")]
        public void GivenThatIAmARegisteredMenteeOnMentorskidSWebpage()
        {
            driver.Navigate().GoToUrl(@"https://mentorskid.com/");
            _availabilityDaysFilterPage.MenteeLoginDetails();

        }
        
        [When(@"I click on find a mentor from the main menu")]
        public void WhenIClickOnFindAMentorFromTheMainMenu()
        {
            _availabilityDaysFilterPage.ClickFindAMentor();
        }
        
        [When(@"I scroll down to mentor availability on the Side Navigation Panel to view all the days of the week")]
        public void WhenIScrollDownToMentorAvailabilityOnTheSideNavigationPanelToViewAllTheDaysOfTheWeek()
        {
            _availabilityDaysFilterPage.ScrollToSideNavigateion();
        }
        
        [When(@"I click the checkbox for my desired day\(s\) of the week")]
        public void WhenIClickTheCheckboxForMyDesiredDaySOfTheWeek()
        {
            _availabilityDaysFilterPage.RandomSelectAvailabilityDays();
        }
        
        [When(@"I click on the Apply filters button")]
        public void WhenIClickOnTheApplyFiltersButton()
        {
            _availabilityDaysFilterPage.ApplyFilterButton();
        }
        
        [Then(@"I must see all the mentors that are available, based on the days I selected")]
        public void ThenIMustSeeAllTheMentorsThatAreAvailableBasedOnTheDaysISelected()
        {
            _availabilityDaysFilterPage.AssertFilteredMessage().Contains("search results found");
        }
    }
}
