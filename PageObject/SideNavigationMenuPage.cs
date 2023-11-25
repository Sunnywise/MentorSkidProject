using MentorSkidSoftwareProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MentorSkidSoftwareProject.PageObject
{
    class SideNavigationMenuPage
    {
        public IWebDriver driver;
        public SideNavigationMenuPage()
        {
            driver=BaseTest.driver;
        }
        private By viewNavigation = By.CssSelector("div[class='tu-uploadinfo'] h6");
        private By collapseSubMenu = By.XPath("//a[normalize-space()='Profile settings']");
        private By expandSubMenu = By.XPath("//i[@class='icon icon-settings']");


        public void ProfileSettingsCollapse()
        {
            Thread.Sleep(5000);
            driver.FindElement(collapseSubMenu).Click();
        }

        public void ProfileSettingsExpand()
        {
            Thread.Sleep(5000);
            driver.FindElement(expandSubMenu).Click();
        }

        public string ViewingSideNavigation()
        {
           Thread.Sleep(7000);
           return driver.FindElement(viewNavigation).Text;
        }
    }
}
