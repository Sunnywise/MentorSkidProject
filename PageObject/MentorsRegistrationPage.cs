using MentorSkidSoftwareProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MentorSkidSoftwareProject.PageObject
{
    class MentorsRegistrationPage
    {
        public static IWebDriver driver;
        public MentorsRegistrationPage()
        {
            driver = BaseTest.driver;
        }

        private By joinMentor = By.XPath("//span[normalize-space()='Join as a Mentor']");
        private By firstName = By.XPath("//input[@name='registration[fname]']"); 
        private By lastName = By.XPath("//input[@placeholder='Last name']");
        private By emailAddy = By.XPath("//input[@name='registration[email]']");
        private By passWord = By.CssSelector("#tu-passwordinput");
        private By showPassword = By.XPath("//i[@class='icon icon-eye-off']");
        private By instructorRadioButton = By.XPath("//label[@for='user_type_instructor']");
        private By termsAndConditions = By.XPath("//label[@for='tu-terms']");
        private By joinUs = By.XPath("//span[normalize-space()='Join now']"); 
        private By errorMsg = By.ClassName("jconfirm-title");
        private By registeredPage = By.XPath("//*[@id='profile-avatar']");


        public void UserClickOnJoinMentor()
        {
            driver.FindElement(joinMentor).Click();
        }
        public void UserEntersFirstName(string p0)
        {
            driver.FindElement(firstName).SendKeys(p0);
        }
        public void UserEntersLastName(string p0)
        {
            driver.FindElement(lastName).SendKeys(p0);
        }
        public void UserEntersEmailAddress(string p0)
        {
            Random random = new Random();
            int randomInt = random.Next(2000);
            driver.FindElement(emailAddy).SendKeys("QATester" + randomInt + "@testing.com");
        }
        public void UserEntersPassword(string p0)
        {
            driver.FindElement(passWord).SendKeys(p0);
        }
        public void PasswordVisible()
        {
            driver.FindElement(showPassword).Click();
        }
        public void UserClickOnInstructorMentor()
        {
            driver.FindElement(instructorRadioButton).Click();
        }
        public void TermsAndConditions()
        {
            driver.FindElement(termsAndConditions).Click();
        }
        public void UserEntersJoinNowButton()
        {
            driver.FindElement(joinUs).Click();
        }
        public bool RedirectedPage()
        {
            Thread.Sleep(3000);
            return driver.FindElement(registeredPage).Displayed;
        }

        public string ErrorInvalidMessage()
        {
            Thread.Sleep(3000);
            return driver.FindElement(errorMsg).Text;
        }

    }
}
