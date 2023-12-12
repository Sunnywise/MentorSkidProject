using AutoItX3Lib;
using MentorSkidSoftwareProject.Hooks;
using MentorSkidSoftwareProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using System.Windows.Input;
using WindowsInputLib;
using WindowsInputLib.Native;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MentorSkidSoftwareProject.PageObject
{
    class UploadingMenteeProfilePhotoPage
    {

        public IWebDriver driver;
        FileLocations _fileLocations;  // declaring and initializing the FileLocations class
        public UploadingMenteeProfilePhotoPage()
        {
            driver = BaseTest.driver;
            _fileLocations = new FileLocations();
        }

        private By uploadBtn = By.LinkText("Upload photo");
        private By imageSlider = By.CssSelector("div[id='crop_img_area'] input[aria-label='zoom']");
        private By saveBtn = By.XPath("//a[@id='save-profile-img']");
        private By successPhotoUpload = By.XPath("//img[@id='user_profile_avatar']");
        private By uploadImage = By.XPath("//*[@id='profile-avatar']");


        public void MenteePhotoUpload()
        {

            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            //wait.PollingInterval = TimeSpan.FromMilliseconds(200);
            //wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@id='profile-avatar']"))).Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            driver.FindElement(uploadBtn).Click();
        }

        public void SelectImageToUpload(string fileImage)
        {

            /* String filePath = @"C:\LocalRepoProject\MentorSkidProjectLocal\MentorSkidProjectRepo\TestDataImages\MenteeImage.jpeg";
              IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
              js.ExecuteScript("document.getElementById('profile-avatar-icon').value='" + filePath + "';"); */

            //driver.FindElement(uploadImage).SendKeys(@"C:\LocalRepoProject\MentorSkidProjectLocal\MentorSkidProjectRepo\TestDataImages\MenteeImage.jpeg");

            /* IWebElement clickable = driver.FindElement(By.Id("profile-avatar-icon"));
             new Actions(driver)
                 .MoveToElement(clickable)
                 .Pause(TimeSpan.FromSeconds(10))
                 .ClickAndHold()
                 .Pause(TimeSpan.FromSeconds(10))
                 .SendKeys(@"C:\LocalRepoProject\MentorSkidProjectLocal\MentorSkidProjectRepo\TestDataImages\MenteeImage.jpeg")
                 .Perform(); */

            Thread.Sleep(10000);
            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open");
            autoIt.Send(@"C:\LocalRepoProject\MentorSkidProjectLocal\MentorSkidProjectRepo\TestDataImages\MenteeImage.jpeg");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            autoIt.Send("{ENTER}");
            Thread.Sleep(5000);

            Actions actions = new Actions(driver);
            actions.SendKeys(Keys.F5).Perform(); 

            
           /* InputSimulator sim = new InputSimulator(); //create an ainstance of the Input simulator class
            sim.Keyboard.TextEntry(@"C:\LocalRepoProject\MentorSkidProjectLocal\MentorSkidProjectRepo\TestDataImages\MenteeImage.jpeg");
            sim.Keyboard.KeyPress(VirtualKeyCode.Enter); */
           
            /*Thread.Sleep(10000);
            string imageFolder = _fileLocations.GetFolderLocation("TestDataImages");
            driver.FindElement(uploadImage).SendKeys(imageFolder + fileImage); */
        }

        public void UploadImageSlider()
        {
          
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0.9727,0)");
        }

        public void SavePictureAsProfilePix()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(4);
            driver.FindElement(saveBtn).Click();
        }

        public bool ImageUploadSuccessfull()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            return driver.FindElement(successPhotoUpload).Displayed;
        }

    }

}
