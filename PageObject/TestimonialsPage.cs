using MentorSkidSoftwareProject.Hooks;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MentorSkidSoftwareProject.PageObject
{
    class TestimonialsPage
    {
        public IWebDriver driver;
        public TestimonialsPage()
        {
            driver= BaseTest.driver;
        }

        private By textTitle = By.CssSelector("section[class='elementor-section elementor-top-section elementor-element elementor-element-32599a9 elementor-section-full_width tu-success-storiesvtwo elementor-section-height-default elementor-section-height-default'] h2:nth-child(1)");
        private By viewRead = By.CssSelector("button[aria-label='Next slide']");
        private By toggleButton = By.CssSelector("button[aria-label='Next slide']");
        private By nextTestimonials = By.CssSelector("div[class='tu-maintitle'] h2 span");

        public void ScrollToFifthSection()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(500,2800)");
        }

        public string TextTitleHeader(string Text)
        {
            Thread.Sleep(3000);
            return driver.FindElement(textTitle).Text;
        }

        public bool ViewAndReadTestimonials()
        {
            Thread.Sleep(3000);
            return driver.FindElement(viewRead).Displayed;
        }

        public void ClickNextThreeTestimonials()
        {
            driver.FindElement(toggleButton).Click();
            Thread.Sleep(3000);
            driver.FindElement(toggleButton).Click();
        }

        public bool ViewNextTestimonials()
        {
            Thread.Sleep(3000);
            return driver.FindElement(nextTestimonials).Displayed;
        }

    }
}
