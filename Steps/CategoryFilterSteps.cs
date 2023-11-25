using MentorSkidSoftwareProject.Hooks;
using MentorSkidSoftwareProject.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MentorSkidSoftwareProject.Features
{
    [Binding]
    public class CategoryFilterSteps
    {
        public IWebDriver driver = BaseTest.driver;
        CategoryFilterPage _categoryFilterPage = new CategoryFilterPage();

        [Given(@"that I am a user of www\.mentorskid\.com")]
        public void GivenThatIAmAUserOfWww_Mentorskid_Com()
        {
            driver.Navigate().GoToUrl(@"https://mentorskid.com/");
        }

        [When(@"I click on Find a Mentor from the Main Menu")]
        public void WhenIClickOnFindAMentorFromTheMainMenu()
        {
            _categoryFilterPage.UserClicksFindMentors();
        }

        [When(@"I click on the angle down icon or select category button")]
        public void WhenIClickOnTheAngleDownIconOrSelectCategoryButton()
        {
            _categoryFilterPage.SelectParentCategory();
        }
        
       
        [When(@"i click on the search now button")]
        public void WhenIClickOnTheSearchNowButton()
        {
            _categoryFilterPage.ClickSearchNow();
        }

        [When(@"i randomly select any course of interest\.")]
        public void WhenIRandomlySelectAnyCourseOfInterest_()
        {
            _categoryFilterPage.RandomCourseSelection();
        }


        [Then(@"I must see all the Subcategories listed on the Side Navigation Panel")]
        public void ThenIMustSeeAllTheSubcategoriesListedOnTheSideNavigationPanel()
        {
            Assert.IsTrue(_categoryFilterPage.AssertUrlPage());
        }
    }
}
