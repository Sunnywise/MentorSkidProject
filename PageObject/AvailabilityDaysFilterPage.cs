using MentorSkidSoftwareProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace MentorSkidSoftwareProject.PageObject
{
    class AvailabilityDaysFilterPage
    {
        public IWebDriver driver;
        public AvailabilityDaysFilterPage()
        {
            driver= BaseTest.driver;
        }

        private By loginBtn = By.XPath("//a[normalize-space()='Login']");
        private By menteeAddy = By.XPath("//input[@placeholder='Username/email']");
        private By passwordInput = By.XPath("//input[@id='tu-passwordinput']");
        private By submitBtn = By.XPath("//a[@class='tu-primbtn-lg tu-user-login']");
        private By findAMentor = By.XPath("//*[@id='menu-item-1990']/a");
        private By filterBtn = By.XPath("//a[@id='tu_search_instructor_filter']");
        private By filterResult = By.CssSelector("div[class='tu-sort'] h3");

        public void MenteeLoginDetails()
        {
            driver.FindElement(loginBtn).Click();
            driver.FindElement(menteeAddy).SendKeys("mentee1@testing.com");
            driver.FindElement(passwordInput).SendKeys("password1234");
            driver.FindElement(submitBtn).Click();
        }

        public void ClickFindAMentor()
        {
            Thread.Sleep(5000);
            driver.FindElement(findAMentor).Click();
        }

        public void ScrollToSideNavigateion()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,810)");

        }

        public void RandomSelectAvailabilityDays()
        {
            Thread.Sleep(3000);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Random random = new Random();
            int randomIndex = random.Next(1,7);
            driver.FindElement(By.XPath("//*[@id='tutur-availability']/div/ul[2]/li["+randomIndex+"]/div/label")).Click();

        }

        public void ApplyFilterButton()
        {
            
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElement(filterBtn).Click();
        }

        public string AssertFilteredMessage()
        {
            return driver.FindElement(filterResult).Text;
        }

    }
}
