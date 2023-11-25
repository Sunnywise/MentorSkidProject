using MentorSkidSoftwareProject.Hooks;
using MentorSkidSoftwareProject.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MentorSkidSoftwareProject.Features
{
    [Binding]
    public class MentorProfileSteps
    {
        public IWebDriver driver = BaseTest.driver;
        MentorProfilePage mentorProfilePage = new MentorProfilePage();

        [Given(@"user is on ""(.*)"" page")]
        public void GivenUserIsOnPage(string p0)
        {
            mentorProfilePage.ProfilePageDisplay().Contains("My Profile");
        }

        [When(@"user select gender from the dropdown menu")]
        public void WhenUserSelectGenderFromTheDropdownMenu()
        {
            mentorProfilePage.SelectGender();
        }
        
        [When(@"user enters hourly fee ""(.*)""")]
        public void WhenUserEntersHourlyFee(string p0)
        {
            mentorProfilePage.HourlyRateFee(p0);
        }
        
        [When(@"user enters his tagline ""(.*)""")]
        public void WhenUserEntersHisTagline(string p0)
        {
            mentorProfilePage.AddYourTagline(p0);
        }
        
        [When(@"user selects his country from the dropdown")]
        public void WhenUserSelectsHisCountryFromTheDropdown()
        {
            mentorProfilePage.MentorCountry();
        }
        
        [When(@"user enters his address ""(.*)""")]
        public void WhenUserEntersHisAddress(string p0)
        {
            mentorProfilePage.MentorAddressName(p0);
        }

        [When(@"user enters his postcode ""(.*)""")]
        public void WhenUserEntersHisPostcode(string p0)
        {
            mentorProfilePage.ZipcodeOfMentor(p0);
        }
       
        [When(@"user select his preferred language or languages")]
        public void WhenUserSelectHisPreferredLanguageOrLanguages()
        {
            mentorProfilePage.MentorLangaugeSelector();
        }
        
        [When(@"user select the teaching location as online")]
        public void WhenUserSelectTheTeachingLocationAsOnline()
        {
            mentorProfilePage.MentorTeachingLocation();
        }
        
        [When(@"user writes out a brief introduction about himself ""(.*)""")]
        public void WhenUserWritesOutABriefIntroductionAboutHimself(string p0)
        {
            mentorProfilePage.MentorBriefIntroduction(p0);
        }
        
        [Then(@"user saves and update his profile")]
        public void ThenUserSavesAndUpdateHisProfile()
        {
            mentorProfilePage.SaveAndUpdateMentorProfile();
        }
    }
}
