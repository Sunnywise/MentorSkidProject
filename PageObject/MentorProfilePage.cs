using MentorSkidSoftwareProject.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MentorSkidSoftwareProject.PageObject
{
    class MentorProfilePage
    {
        public IWebDriver driver;
        public MentorProfilePage()
        {
            driver=BaseTest.driver;
        }

        private By profilePage = By.XPath("//h4[normalize-space()='My Profile']");
        private By genderSelectMale = By.XPath("//select[@name='gender']");
        private By hourlyFee = By.Name("hourly_rate");
        private By tagLine = By.Name("tagline");
        private By choiceCountry = By.XPath("//select[@id='tu_country']");
        private By cityName = By.CssSelector("input[placeholder='Enter your city']");
        private By addressName = By.XPath("//input[@placeholder='Enter your address']");
        private By postcodeMentor = By.XPath("//input[@placeholder='Enter postcode']");
        private By selectLanguages = By.XPath("//select[@id='tu-languages']");
        private By onlineLocation = By.CssSelector("label[for='online']");
        private By inFrameText = By.XPath("//button[@id='profile_introduction-html']");
        private By saveBtn = By.XPath("//a[normalize-space()='Save & update']");



        public string ProfilePageDisplay()
        {
            Thread.Sleep(7000);
            return driver.FindElement(profilePage).Text;
        }

        public void SelectGender()
        {
            SelectElement select = new SelectElement(driver.FindElement(genderSelectMale));
            select.SelectByValue("male");
        }

        public void HourlyRateFee(string p0)
        {
            driver.FindElement(hourlyFee).Clear();
            Thread.Sleep(2000);
            driver.FindElement(hourlyFee).SendKeys(p0);
        }

        public void AddYourTagline(String p0)
        {
            driver.FindElement(tagLine).SendKeys(p0);
        }

        public void MentorCountry()
        {
            Thread.Sleep(3000);
            SelectElement ctry = new SelectElement(driver.FindElement(choiceCountry));
            ctry.SelectByValue("gb");
        }

        public void MentorCityName(string p0)
        {
            Thread.Sleep(2000);
            driver.FindElement(cityName).SendKeys(p0);
        }

        public void MentorAddressName(string p0)
        {
            Thread.Sleep(2000);
            driver.FindElement(addressName).SendKeys(p0);
        }

        public void ZipcodeOfMentor(string p0)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,650)");
            Thread.Sleep(3000);
            driver.FindElement(postcodeMentor).SendKeys(p0);
        }

        public void MentorLangaugeSelector()
        {
            Thread.Sleep(4000);
            SelectElement languages = new SelectElement(driver.FindElement(selectLanguages));
            languages.SelectByValue("english");  
        }

        public void MentorTeachingLocation()
        {
            Thread.Sleep(3000);
            driver.FindElement(onlineLocation).Click();
        }

        public void MentorBriefIntroduction(string p0)
        {
            Thread.Sleep(5000);
            driver.FindElement(inFrameText).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//textarea[@id='profile_introduction']")).SendKeys(p0);
        }

        public void SaveAndUpdateMentorProfile()
        {
            Thread.Sleep(3000);
            IJavaScriptExecutor JS = (IJavaScriptExecutor)driver;
            JS.ExecuteScript("window.scrollTo(0, 1200)");
            Thread.Sleep(2000);
            driver.FindElement(saveBtn).Click();
        }
    }
}
