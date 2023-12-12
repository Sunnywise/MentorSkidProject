using FluentAssertions;
using MentorSkidSoftwareProject.Hooks;
using MentorSkidSoftwareProject.PageObject;
using MentorSkidSoftwareProject.Utilities;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MentorSkidSoftwareProject.Steps
{
    [Binding]
    public class UploadingMenteeProfilePhotoSteps
    {
        public IWebDriver driver = BaseTest.driver;
        UploadingMenteeProfilePhotoPage _uploadingMenteeProfilePhotoPage = new UploadingMenteeProfilePhotoPage();
    

        [When(@"I click upload photo as a mentee")]
        public void WhenIClickUploadPhotoAsAMentee()
        {
            _uploadingMenteeProfilePhotoPage.MenteePhotoUpload();
        }

        [When(@"I select the desire photo to upload ""(.*)""")]
        public void WhenISelectTheDesirePhotoToUpload(string fileImage)
        {
            _uploadingMenteeProfilePhotoPage.SelectImageToUpload(fileImage);
        }
       
        [When(@"I click and drag the slider to crop my image if necessary")]
        public void WhenIClickAndDragTheSliderToCropMyImageIfNecessary()
        {
            _uploadingMenteeProfilePhotoPage.UploadImageSlider();
        }

        [When(@"I click on save button to save the photo")]
        public void WhenIClickOnSaveButtonToSaveThePhoto()
        {
            _uploadingMenteeProfilePhotoPage.SavePictureAsProfilePix();
        }
        
        [Then(@"the photo is successfully uploaded")]
        public void ThenThePhotoIsSuccessfullyUploaded()
        {
            _uploadingMenteeProfilePhotoPage.ImageUploadSuccessfull().Should().BeTrue();
        }
    }
}
