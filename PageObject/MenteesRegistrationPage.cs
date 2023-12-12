using MentorSkidSoftwareProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MentorSkidSoftwareProject.PageObject
{
    class MenteesRegistrationPage
    {
        public static IWebDriver driver;
        public MenteesRegistrationPage()
        {
            driver = BaseTest.driver;
        }

        private By starterMentee = By.CssSelector("a[class='tu-primbtn tu-primbtn-gradient'] span");
        private By firstName = By.XPath("//input[@name='registration[fname]']");
        private By lastName = By.XPath("//input[@placeholder='Last name']");
        private By passWord = By.CssSelector("#tu-passwordinput");
        private By showPassword = By.XPath("//i[@class='icon icon-eye-off']");
        private By instructorCheckbox = By.XPath("//label[@for='user_type_instructor']");
        private By studentCheckbox = By.CssSelector("label[for='user_type_student']");
        private By termsConditions = By.XPath("//label[@for='tu-terms']");
        private By joinUs = By.XPath("//span[normalize-space()='Join now']");
        private By errorText =By.Id("jconfirm-box");   
        private By loginWelcome = By.CssSelector("#user_profile_avatar");
        IWebElement emailAddy => driver.FindElement(By.XPath("//input[@name='registration[email]']"));

        public void UserClickOnStartMentee()
        {
            driver.FindElement(starterMentee).Click();
        }
        public void UserEntersFirstName(string FirstName)
        {
            driver.FindElement(firstName).SendKeys(FirstName);
        }
        public void UserEntersLastName(string p0)
        {
            driver.FindElement(lastName).SendKeys(p0);
        }
        public void UserEntersEmailAddress(string p0)
        {
            Random random = new Random();
            int randomInt = random.Next(2000);
            emailAddy.SendKeys("QATester" + randomInt + "@testing.com");
        }
        public void UserEntersPassword(string p0)
        {
            driver.FindElement(passWord).SendKeys(p0);
        }
        public void PasswordVisible()
        {
            driver.FindElement(showPassword).Click();
        }
        public void UserClickOnStudentMentee()
        {
            driver.FindElement(studentCheckbox).Click();
        }
        public void TermsAndConditions()
        {
            driver.FindElement(termsConditions).Click();
        }
        public void UserEntersJoinNowButton()
        {
            driver.FindElement(joinUs).Click();
        }
        public bool RegisteredLoginPage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            return driver.FindElement(loginWelcome).Displayed;
        }

        public string OopsMessageIsDisplayed()
        {   
            return driver.FindElement(errorText).Text;
        }                
    }
}
