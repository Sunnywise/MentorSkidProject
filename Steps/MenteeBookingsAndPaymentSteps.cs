using FluentAssertions;
using MentorSkidSoftwareProject.Hooks;
using MentorSkidSoftwareProject.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MentorSkidSoftwareProject.Features
{
    [Binding]
    public class MenteeBookingsAndPaymentSteps
    {
        public static IWebDriver driver = BaseTest.driver;
        MenteeBookingsAndPaymentPage _menteeBookingsAndPaymentPage = new MenteeBookingsAndPaymentPage();

        [Given(@"user clicks the View Profile button for the Mentor of my choice")]
        public void GivenUserClicksTheViewProfileButtonForTheMentorOfMyChoice()
        {
            _menteeBookingsAndPaymentPage.UserViewProfile();
        }
        
        [Given(@"user clicks on the View profile button of mentor without bookings")]
        public void GivenUserClicksOnTheViewProfileButtonOfMentorWithoutBookings()
        {
            _menteeBookingsAndPaymentPage.UnavailableMentorView();
        }
        
        [When(@"user clicks on the Book a session button")]
        public void WhenUserClicksOnTheBookASessionButton()
        {
            _menteeBookingsAndPaymentPage.UserBookASession();
        }
        
        [When(@"user completes the booking details fields to indicate my availability")]
        public void WhenUserCompletesTheBookingDetailsFieldsToIndicateMyAvailability()
        {
            _menteeBookingsAndPaymentPage.AllBookingDetailsFields();
        }
        
        [When(@"user clicks on the Show availability button")]
        public void WhenUserClicksOnTheShowAvailabilityButton()
        {
            _menteeBookingsAndPaymentPage.ClickShowAvailabilityBtn();
        }
        
        [When(@"user clicks on an available slot of my choice")]
        public void WhenUserClicksOnAnAvailableSlotOfMyChoice()
        {
            _menteeBookingsAndPaymentPage.UserSelectSlotChoice();
        }
        
        [When(@"user clicks on the Save & continue button")]
        public void WhenUserClicksOnTheSaveContinueButton()
        {
            _menteeBookingsAndPaymentPage.ClickSaveAndContinueBtn1();
        }
        
        [When(@"user clicks on the Save & continue button again")]
        public void WhenUserClicksOnTheSaveContinueButtonAgain()
        {
            _menteeBookingsAndPaymentPage.ClickSaveAndContinueBtn2();
        }
        
        [When(@"user clicks on the proceed to checkout button")]
        public void WhenUserClicksOnTheProceedToCheckoutButton()
        {
            _menteeBookingsAndPaymentPage.UserProceedToCheckout();
        }

        [When(@"user completes the billing details fields")]
        public void WhenUserCompletesTheBillingDetailsFields()
        {
            _menteeBookingsAndPaymentPage.BillingDetails("TesterAlpha");
            _menteeBookingsAndPaymentPage.LastName("TesterBeta");
            _menteeBookingsAndPaymentPage.CompanyName("Alpha Beta Consulting");
            _menteeBookingsAndPaymentPage.StreetName("Tester Avenue");
            _menteeBookingsAndPaymentPage.TownOrCity("Tester City");
            _menteeBookingsAndPaymentPage.PostCode("TA11 22TB");
            _menteeBookingsAndPaymentPage.PhoneNumber("");

        }


        [When(@"user enters my test card details")]
        public void WhenUserEntersMyTestCardDetails()
        {
            _menteeBookingsAndPaymentPage.TestCardNumber("4242424242424242");
            _menteeBookingsAndPaymentPage.TestCardExpiryDate("1227");
            _menteeBookingsAndPaymentPage.TestCardCVC("321");
        }

        [When(@"user clicks on the place order button")]
        public void WhenUserClicksOnThePlaceOrderButton()
        {
            _menteeBookingsAndPaymentPage.UserPlacOrder();
        }
        
        [Then(@"user clicks on Find a Mentor from the Menu Bar")]
        public void ThenUserClicksOnFindAMentorFromTheMenuBar()
        {
            _menteeBookingsAndPaymentPage.UserFindAMentor();
        }
        
        [Then(@"user is directed to the ""(.*)"" confirmation page")]
        public void ThenUserIsDirectedToTheConfirmationPage(string Text)
        {
            _menteeBookingsAndPaymentPage.OrderedConfirmationMessage().Contains("Order received");
        }


        [Then(@"an error message pops up as ""(.*)""")]
        public void ThenAnErrorMessagePopsUpAs(string p0)
        {
            _menteeBookingsAndPaymentPage.NoSlotsAvailable();
        }
    }
}
