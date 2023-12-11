using MentorSkidSoftwareProject.Hooks;
using MentorSkidSoftwareProject.PageObject;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MentorSkidSoftwareProject.Features
{
    [Binding]
    public class PasswordResetSteps
    {
        public IWebDriver driver = BaseTest.driver;
        PasswordResetPage _passwordResetPage = new PasswordResetPage();

        [Given(@"that I am on the password reset page")]
        public void GivenThatIAmOnThePasswordResetPage()
        {
             var Url = "https://mentorskid.com/reset-password/";
            driver.Navigate().GoToUrl(Url);

        }
        
        [When(@"I enter my email address")]
        public void WhenIEnterMyEmailAddress()
        {
            
            _passwordResetPage.EnterEmailReset("QATester@fake-box.com");
        }

        [When(@"click the Reset password Button")]
        public void WhenClickTheResetPasswordButton()
        {
            _passwordResetPage.ClickResetButton();
        }

  
        [When(@"I click on the password reset link in my email")]
        public void WhenIClickOnThePasswordResetLinkInMyEmail()
        {
            _passwordResetPage.SwitchToMailTab();
        }

        [When(@"I am directed to a page where I can enter a new password")]
        public void WhenIAmDirectedToAPageWhereICanEnterANewPassword()
        {
            _passwordResetPage.EnterNewPassword("");
        }
        
        [When(@"I enter my new password")]
        public void WhenIEnterMyNewPassword()
        {
            _passwordResetPage.EnterNewPassword("");
        }
        
        [When(@"I re-enter my new password")]
        public void WhenIRe_EnterMyNewPassword()
        {
            _passwordResetPage.EnterNewPasswordAgain("");
        }

       
        [When(@"I click on the submit button")]
        public void WhenIClickOnTheSubmitButton()
        {
            _passwordResetPage.ClickResetPasswordButton();
        }

        [Then(@"my password must be successfully reset")]
        public void ThenMyPasswordMustBeSuccessfullyReset()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
