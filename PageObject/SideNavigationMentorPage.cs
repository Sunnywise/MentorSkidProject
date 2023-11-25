using MentorSkidSoftwareProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MentorSkidSoftwareProject.PageObject
{
    class SideNavigationMentorPage
    {
        public IWebDriver driver;
        public SideNavigationMentorPage()
        {
            driver=BaseTest.driver;
        }

        IWebElement regEmail => driver.FindElement(By.XPath("//input[@placeholder='Username/email']"));
        IWebElement regPassword => driver.FindElement(By.XPath("//input[@id='tu-passwordinput']"));
        IWebElement submitBtn => driver.FindElement(By.XPath("//a[@class='tu-primbtn-lg tu-user-login']"));
        IWebElement profilePage => driver.FindElement(By.XPath("//*[@id='profile-avatar']"));
        private By viewNavigation = By.CssSelector("div[class='tu-uploadinfo'] h6");
        private By collapseSubMenu = By.XPath("//a[normalize-space()='Profile settings']");
        private By expandSubMenu = By.XPath("//i[@class='icon icon-settings']");


        public void UserRegisteredEmail(string p0)
        {
            regEmail.SendKeys(p0);
        }

        public void UserRegisteredPassword(string p0)
        {
            regPassword.SendKeys(p0);
        }

        public void UserSubmitBtn()
        {
            submitBtn.Click();
        }

        public bool UserRegisteredPage()
        {
            Thread.Sleep(3000);
            return profilePage.Displayed;
        }


        public void ProfileSettingsExpand()
        {
            Thread.Sleep(5000);
            driver.FindElement(expandSubMenu).Click();
        }
      
        public void ProfileSettingsCollapse()
        {
            Thread.Sleep(5000);
            driver.FindElement(collapseSubMenu).Click();
        }

        public string ViewingSideNavigation()
        {
            Thread.Sleep(7000);
            return driver.FindElement(viewNavigation).Text;
        }

    }
}
