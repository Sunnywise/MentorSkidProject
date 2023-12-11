using FluentAssertions;
using MentorSkidSoftwareProject.Hooks;
using MentorSkidSoftwareProject.PageObject;
using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MentorSkidSoftwareProject.Features
{
    [Binding]
    public class MentorAvailabilitySteps
    {
        public IWebDriver driver = BaseTest.driver;
        MentorAvailabilityPage _mentorAvailabilityPage = new MentorAvailabilityPage();

        [Given(@"user clicks on Add time slots\.")]
        public void GivenUserClicksOnAddTimeSlots_()
        {
            _mentorAvailabilityPage.ClickAddTimeSlot();
           
        }

        [Given(@"user clicks on new add time slots")]
        public void GivenUserClicksOnNewAddTimeSlots()
        {
            _mentorAvailabilityPage.AddNewTimeSlots();
        }

        [Given(@"user selects available service days from the drop-down")]
        public void GivenUserSelectsAvailableServiceDaysFromTheDrop_Down()
        {
            // _mentorAvailabilityPage.RandomSelectAvailableServiceDays();
            _mentorAvailabilityPage.SelectDaysFromList();
        }

        [Given(@"user enters the Slot/Appointment Title in the text field as ""(.*)""")]
        public void GivenUserEntersTheSlotAppointmentTitleInTheTextFieldAs(string p0)
        {
            _mentorAvailabilityPage.EntersSlotTitle(p0);
        }

               
        [Given(@"user selects the start and end times from the drop list")]
        public void GivenUserSelectsTheStartAndEndTimesFromTheDropList()
        {
            _mentorAvailabilityPage.SelectStartTime();
            _mentorAvailabilityPage.SelectEndTime();
        }
        
        [Given(@"user selects Break time from the drop-down list")]
        public void GivenUserSelectsBreakTimeFromTheDrop_DownList()
        {
            _mentorAvailabilityPage.SelectBreakTime();
        }
        
        [Given(@"user selects Session duration from the drop-down list")]
        public void GivenUserSelectsSessionDurationFromTheDrop_DownList()
        {
            _mentorAvailabilityPage.ClickSessionDuration();
        }
        
        [Given(@"user selects the number of appointment spaces from the checkbox")]
        public void GivenUserSelectsTheNumberOfAppointmentSpacesFromTheCheckbox()
        {
            _mentorAvailabilityPage.RandomSelectAppointmentSpaces();
        }
        
        [Given(@"user clicks on the Add unavailable days\.")]
        public void GivenUserClicksOnTheAddUnavailableDays_()
        {
            _mentorAvailabilityPage.clickUnavailabilityDay1();
            Thread.Sleep(2000);
            _mentorAvailabilityPage.AddUnavailabilityDays2();
        }
        
        [When(@"a user clicks on the My Calendar button at the side navigation panel")]
        public void WhenAUserClicksOnTheMyCalendarButtonAtTheSideNavigationPanel()
        {
            _mentorAvailabilityPage.ClickMyCalendarButton();
        }
        
        [When(@"user clicks on the Generate appointment slots button")]
        public void WhenUserClicksOnTheGenerateAppointmentSlotsButton()
        {
            _mentorAvailabilityPage.GenerateTimeSlot();
        }
        
        [When(@"user selects start and end dates\.")]
        public void WhenUserSelectsStartAndEndDates_()
        {
            _mentorAvailabilityPage.StartAndEndDates();
        }
        
        [When(@"user clicks on the Mark these days unavailable\.")]
        public void WhenUserClicksOnTheMarkTheseDaysUnavailable_()
        {
            _mentorAvailabilityPage.MarkSelectedDaysUnavailable();
        }
        
        [When(@"user clicks on save and update changes\.")]
        public void WhenUserClicksOnSaveAndUpdateChanges_()
        {
            _mentorAvailabilityPage.SaveAndUpdateChanges();
        }
        
        [Then(@"user clicks on Add/Edit bookings\.")]
        public void ThenUserClicksOnAddEditBookings_()
        {
            _mentorAvailabilityPage.ClickAddEditBookings();
        }
        
        [Then(@"my appointment slots must be generated")]
        public void ThenMyAppointmentSlotsMustBeGenerated()
        {
            _mentorAvailabilityPage.BookingsSuccessMessage();
        }
        
        [Then(@"success update message pops up")]
        public void ThenSuccessUpdateMessagePopsUp()
        {
            _mentorAvailabilityPage.UnavailableDateRegistered().Should().BeTrue();
        }
    }
}
