using AutoItX3Lib;
using MentorSkidSoftwareProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MentorSkidSoftwareProject.PageObject
{
  /*  class UploadingMentorProfilePhotoPage
    {
        public IWebDriver driver;
        public UploadingMentorProfilePhotoPage()
        {
            driver = BaseTest.driver;
        }

        private By uploadBtn = By.LinkText("Upload photo");
        private By imageSlider = By.CssSelector("div[id='crop_img_area'] input[aria-label='zoom']");
        private By saveBtn = By.XPath("//a[@id='save-profile-img']");
        private By successPhotoUpload = By.XPath("//img[@id='user_profile_avatar']");

        public void MentorPhotoUpload()
        {
            Thread.Sleep(15000);
            driver.FindElement(uploadBtn).Click();   
        }

        public void SelectMentorImageToUpload()
        {
            Thread.Sleep(10000);
            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");
            autoIt.Send(@"C:\LocalRepoProject\MentorSkidProjectLocal\MentorSkidProjectRepo\TestDataImages\QAlogo.png");
            Thread.Sleep(10000);
            autoIt.Send("{ENTER}");
        }

        public void UploadMentorImageSlider()
        {
            Thread.Sleep(10000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0.9727,0)");
        }

        public void SaveMentorPictureAsProfilePix()
        {
            Thread.Sleep(10000);
            driver.FindElement(saveBtn).Click();
        }

        public bool MentorImageUploadSuccessfull()
        {
            Thread.Sleep(10000);
            return driver.FindElement(successPhotoUpload).Displayed;
        }

    }
  */
}
