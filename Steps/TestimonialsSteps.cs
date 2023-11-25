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
    public class TestimonialsSteps
    {
        public IWebDriver driver = BaseTest.driver;
        TestimonialsPage testimonialsPage = new TestimonialsPage();

        [Given(@"a user navigates to www\.mentorskid\.com")]
        public void GivenAUserNavigatesToWww_Mentorskid_Com()
        {
            driver.Navigate().GoToUrl("https://mentorskid.com/");
        }
        
        [When(@"user scrolls to the fifth section on the landing page")]
        public void WhenUserScrollsToTheFifthSectionOnTheLandingPage()
        {
            testimonialsPage.ScrollToFifthSection();
        }
        
        [When(@"user should read the text title header as ""(.*)""")]
        public void WhenUserShouldReadTheTextTitleHeaderAs(string Text)
        {
            testimonialsPage.TextTitleHeader("See how our members have made their success stories ..."); //.Contain("See how our members have made their success stories ...");
        }
        
        [When(@"user clicks the toggle button for the image carousel")]
        public void WhenUserClicksTheToggleButtonForTheImageCarousel()
        {
            testimonialsPage.ClickNextThreeTestimonials();
        }
        
        [Then(@"user must be able to view and read the three testimonials in a container")]
        public void ThenUserMustBeAbleToViewAndReadTheThreeTestimonialsInAContainer()
        {
            Assert.IsTrue(testimonialsPage.ViewAndReadTestimonials());
        }
        
        [Then(@"user must see the next testimonials\.")]
        public void ThenUserMustSeeTheNextTestimonials_()
        {
            testimonialsPage.ViewNextTestimonials().Should().BeTrue();
        }
    }
}
