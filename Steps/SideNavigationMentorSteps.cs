using MentorSkidSoftwareProject.Hooks;
using MentorSkidSoftwareProject.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MentorSkidSoftwareProject.Features
{
    [Binding]
    public class SideNavigationMentorSteps
    {
        [Given(@"that a user navigate on https://mentorskid\.com/login/")]
        public void GivenThatAUserNavigateOnHttpsMentorskid_ComLogin()
        {
            driver.Navigate().GoToUrl(@"https://mentorskid.com/login/");
        }

        [When(@"user enters username or email address ""(.*)""")]
        public void WhenUserEntersUsernameOrEmailAddress(string p0)
        {
            _sideNavigationMentorPage.UserRegisteredEmail(p0);
        }

        [When(@"user enters login password ""(.*)""")]
        public void WhenUserEntersLoginPassword(string p0)
        {
            _sideNavigationMentorPage.UserRegisteredPassword(p0);
        }

        [When(@"user clicks on submit button")]
        public void WhenUserClicksOnSubmitButton()
        {
            _sideNavigationMentorPage.UserSubmitBtn();
        }

        [Then(@"the user registered page is displayed")]
        public void ThenTheUserRegisteredPageIsDisplayed()
        {
            Assert.IsTrue(_sideNavigationMentorPage.UserRegisteredPage());
        }


        public static IWebDriver driver = BaseTest.driver;
        SideNavigationMentorPage _sideNavigationMentorPage = new SideNavigationMentorPage();


        [Given(@"user sees the side navigation panel with ""(.*)"" message\.")]
        public void GivenUserSeesTheSideNavigationPanelWithMessage_(string p0)
        {
            _sideNavigationMentorPage.ViewingSideNavigation().Contains("You can upload");
        }
        
        [When(@"user clicks on the dropdown icon for the submenu to collape\.")]
        public void WhenUserClicksOnTheDropdownIconForTheSubmenuToCollape_()
        {
            _sideNavigationMentorPage.ProfileSettingsCollapse();
        }
        
        [Then(@"user clicks on the forward arrow icon for the submenu to expand to view the sub-menu\.")]
        public void ThenUserClicksOnTheForwardArrowIconForTheSubmenuToExpandToViewTheSub_Menu_()
        {
            //_sideNavigationMentorPage.ProfileSettingsExpand().Should().BeTrue();
            _sideNavigationMentorPage.ProfileSettingsExpand();
        }
    }
}
