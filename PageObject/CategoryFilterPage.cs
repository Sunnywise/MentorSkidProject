using MentorSkidSoftwareProject.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MentorSkidSoftwareProject.PageObject
{
    class CategoryFilterPage
    {
        public IWebDriver driver;
        public CategoryFilterPage()
        {
            driver = BaseTest.driver;
        }

        private By findMentor = By.XPath("//a[normalize-space()='Find a Mentor']");
        private By selectCategory = By.CssSelector("#select2-parent-category-search-dropdown-container");
        private By searchNow = By.CssSelector("#tu-instructor-search-keyword");
        

        public void UserClicksFindMentors()
        {
            driver.FindElement(findMentor).Click();
        }

        public void SelectParentCategory()
        {
           // driver.FindElement(selectCategory).Click();
            SelectElement objSelect = new SelectElement(driver.FindElement(By.XPath("//select[@id='parent-category-search-dropdown']")));
            objSelect.SelectByValue("quality-testing");
        }

        public void ClickSearchNow()
        {
            driver.FindElement(searchNow).Click();
            Thread.Sleep(3000);
        }

        public void RandomCourseSelection()
        {
            driver.FindElement(By.XPath("//a[@class='tu-readmorebtn tu-show_more']")).Click();
            Thread.Sleep(3000);

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,510)");

            Thread.Sleep(3000);
            Random random = new Random();
            int randomIndex = random.Next(299, 303);
            driver.FindElement(By.XPath("//label[@for='expcheck"+randomIndex+"']")).Click();

            //To SELECT ALL CHECKBOXES
            //IList<IWebElement> checkboxes = driver.FindElements(By.XPath("//input[@type='checkbox']"));
            /* IList<IWebElement> checkboxes = driver.FindElements(By.XPath("//div[@class='tu-check tu-checksm']"));
             foreach (IWebElement checkbox in checkboxes)
             {
                 if (!checkbox.Selected)
                 {
                     checkbox.Click();
                 }
             } */

        }

        public bool AssertUrlPage()
        {
            string AssertUrl = "https://mentorskid.com/find-instructors/?keyword=&categories=quality-testing";
            return driver.Url.Contains(AssertUrl);
        }


    }
}
