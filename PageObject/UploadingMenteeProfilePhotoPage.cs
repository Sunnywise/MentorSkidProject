using AutoItX3Lib;
using MentorSkidSoftwareProject.Hooks;
using MentorSkidSoftwareProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MentorSkidSoftwareProject.PageObject
{
    class UploadingMenteeProfilePhotoPage
    {
        
        //public IWebDriver driver;
        //FileLocations _fileLocations;  // declaring and initializing the FileLocations class
        //public UploadingMenteeProfilePhotoPage()
        //{
        //    driver = BaseTest.driver;
        //    _fileLocations = new FileLocations();
        //}


        //private By uploadBtn = By.LinkText("Upload photo");
        //private By imageSlider = By.CssSelector("div[id='crop_img_area'] input[aria-label='zoom']");
        //private By saveBtn = By.XPath("//a[@id='save-profile-img']");
        //private By successPhotoUpload = By.XPath("//img[@id='user_profile_avatar']");
        //private By uploadImage = By.XPath("//*[@id='profile-avatar']"); //By.XPath("//*[@id='profile-avatar-icon']");  

        
        //public void MenteePhotoUpload()
        //{
        //    Thread.Sleep(15000);
        //    driver.FindElement(uploadBtn).Click();
        //}

        //public void SelectImageToUpload(string fileImage)
        //{

        //    //IJavaScriptExecutor js = (IJavaScriptExecutor)driver; 
        //    //js.ExecuteScript("document.getElementById('profile-avatar-icon').style.display = 'block';"); 
        //    //driver.FindElement(By.Id("profile-avatar-icon")).SendKeys(@"C:\LocalRepoProject\MentorSkidProjectLocal\MentorSkidProjectRepo\Utilities\TestingPhoto.jpg");
        //    //js.ExecuteScript("document.getElementById('profile-avatar-icon').style.display = 'none';");

        //    //String filePath = @"C:\LocalRepoProject\MentorSkidProjectLocal\MentorSkidProjectRepo\Utilities\TestingPhoto.jpg";

        //    //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //    //js.ExecuteScript("document.getElementById('profile-avatar-icon').style.display = 'block';");
        //    //driver.FindElement(By.Id("profile-avatar-icon")).SendKeys(@"C:\LocalRepoProject\MentorSkidProjectLocal\MentorSkidProjectRepo\Utilities\TestingPhoto.jpg");
        //    //js.ExecuteScript("document.getElementById('profile-avatar-icon').style.display = 'none';");

        //    //IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //    //js.ExecuteScript("document.getElementById('profile-avatar-icon').value='" + filePath + "';");

        //    // driver.FindElement(uploadImage).SendKeys(@"C:\LocalRepoProject\MentorSkidProjectLocal\MentorSkidProjectRepo\Utilities\TestingPhoto.jpg");
        //    //new Actions(driver)
        //    //    .keyDown(Keys.SHIFT)
        //    //    .sendKeys("a")
        //    //    .perform();

        //    //IWebElement clickable = driver.FindElement(By.Id("profile-avatar-icon"));
        //    //new Actions(driver)
        //    //    .MoveToElement(clickable)
        //    //    .Pause(TimeSpan.FromSeconds(1))
        //    //    .ClickAndHold()
        //    //    .Pause(TimeSpan.FromSeconds(1))
        //    //    .SendKeys(@"C:\LocalRepoProject\MentorSkidProjectLocal\MentorSkidProjectRepo\Utilities\TestingPhoto.jpg")
        //    //    .Perform();

        //    Thread.Sleep(10000);
        //    AutoItX3 autoIt = new AutoItX3();
        //    autoIt.WinActivate("Open");
        //    autoIt.Send(@"C:\LocalRepoProject\MentorSkidProjectLocal\MentorSkidProjectRepo\TestDataImages\TestingImage.png");
        //    Thread.Sleep(5000);
        //    autoIt.Send("{ENTER}");

        //    /* string imageFolder = _fileLocations.GetFolderLocation("TestDataImages");
        //     driver.FindElement(uploadImage).SendKeys(imageFolder + fileImage); */

        //}

        //public void UploadImageSlider()
        //{
        //    Thread.Sleep(5000);
        //    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //    js.ExecuteScript("window.scrollTo(0.9727,0)");
        //}

        //public void SavePictureAsProfilePix()
        //{
        //    Thread.Sleep(4000);
        //    driver.FindElement(saveBtn).Click();
        //}

        //public bool ImageUploadSuccessfull()
        //{
        //    Thread.Sleep(3000);
        //    return driver.FindElement(successPhotoUpload).Displayed;
        //}
    
    } 
    
}
