using FluentAssertions;
using MentorSkidSoftwareProject.Hooks;
using MentorSkidSoftwareProject.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MentorSkidSoftwareProject.Features
{
  [Binding]
    public class SideNavigationMenuSteps
    {
        public static IWebDriver driver = BaseTest.driver;
        SideNavigationMenuPage _sideNavigationMenuPage = new SideNavigationMenuPage();

        [Given(@"I view the Side Navigation Panel with upload text messages ""(.*)""")]
        public void GivenIViewTheSideNavigationPanelWithUploadTextMessages(string p0)
        {
            _sideNavigationMenuPage.ViewingSideNavigation().Contains("You can upload");
        }

        [Given(@"I click on the downward arrow icon for the submenu to collape")]
        public void GivenIClickOnTheDownwardArrowIconForTheSubmenuToCollape()
        {
            _sideNavigationMenuPage.ProfileSettingsCollapse();
        }

        [Then(@"I click on the forward arrow icon for the sub-menu to expand")]
        public void ThenIClickOnTheForwardArrowIconForTheSub_MenuToExpand()
        {
            //_sideNavigationMenuPage.ProfileSettingsExpand().Should().BeTrue();
            _sideNavigationMenuPage.ProfileSettingsExpand();
        }




    }
}
