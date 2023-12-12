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
        private By selectCategory = By.CssSelector("#select2-parent-cat                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  egory-search-dropdown-container");
        private By searchNow = By.CssSelector("#tu-instructor-search-keyword");
        private By invalidMessage = By.CssSelector("div[class='tu-sort'] h3");
        private By subjectNlevel = By.CssSelector("#instructor-search-dropdown");
        private By subCategory = By.CssSelector("label[for='expcheck329']");
        private By applyFilter = By.XPath("//a[@id='tu_search_instructor_filter']");
        private By msgResult = By.XPath("/html/body/main/section/div/div/div[1]/div/div/h3");
        public void UserClicksFindMentors()
        {
            driver.FindElement(findMentor).Click();
        }

        public void SelectParentCategory()
        {
            SelectElement objSelect = new SelectElement(driver.FindElement(By.XPath("//select[@id='parent-category-search-dropdown']")));
            objSelect.SelectByValue("quality-testing");
        }

        public void ClickSearchNow()
        {
            driver.FindElement(searchNow).Click();
        }

        public void RandomCourseSelection()
        {

            driver.FindElement(By.XPath("//a[@class='tu-readmorebtn tu-show_more']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,510)");

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            Random random = new Random();
            int randomIndex = random.Next(299, 303);
            driver.FindElement(By.XPath("//label[@for='expcheck"+randomIndex+"']")).Click();

        }

        public bool AssertUrlPage()
        {
            string AssertUrl = "https://mentorskid.com/find-instructors/?keyword=&categories=quality-testing";
            return driver.Url.Contains(AssertUrl);
        }

        public string AssertUnavailableMessage()
        {
            return driver.FindElement(invalidMessage).Text;
        }

        public void SearchCategoriesBySideNav()
        {
            SelectElement sele = new SelectElement(driver.FindElement(subjectNlevel));
            sele.SelectByValue("cv-reviews");
        }

        public void SubCategorySelection()
        {
            driver.FindElement(subCategory).Click();
        }

        public void ClickApplyFilterBtn()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,1600)");
            Thread.Sleep(3000);
            driver.FindElement(applyFilter).Click();
        }
       
        public string SearchResultDisplay()
        {
            return driver.FindElement(msgResult).Text;
        }

    }
}
