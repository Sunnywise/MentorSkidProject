using MentorSkidSoftwareProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentorSkidSoftwareProject.PageObject
{
     public class MentorsProfileLinkPage
     {
        public IWebDriver driver;
        public MentorsProfileLinkPage()
        {
            driver = BaseTest.driver;
        }

        private By findAMentor = By.XPath("//a[normalize-space()='Find a Mentor']");
        private By viewProfile = By.XPath("(//*[@class='tu-btn'][1])[1]");
        private By linkUrl = By.XPath("//*[@id='urlcopy']/a");
        private By logoAssertion = By.XPath("//*[@class='amsvglogo']");

        public void ClickFindAMentor()
        {
            driver.FindElement(findAMentor).Click();
        }

        public void ClickViewProfile()
        {
            driver.FindElement(viewProfile).Click();
        }

        public void ClickUrlLink()
        {
            driver.FindElement(linkUrl).Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
        }

        public bool AssertLogo()
        {
            return driver.FindElement(logoAssertion).Displayed;
        }

     }
}
