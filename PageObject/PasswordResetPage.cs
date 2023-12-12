using MentorSkidSoftwareProject.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MentorSkidSoftwareProject.PageObject
{
    public class PasswordResetPage
    {
        public IWebDriver driver;
        public PasswordResetPage()
        {
            driver=BaseTest.driver;
        }

        private By emailReset = By.XPath("//input[@id='somfrp_user_info']");
        private By resetBtn = By.XPath("//button[@id='reset-pass-submit']");
        private By newPassword = By.XPath("//input[@id='som_new_user_pass']");
        private By newPassword2 = By.XPath("//input[@id='som_new_user_pass_again']");
        private By newPasswordResetBtn = By.XPath("//button[@id='reset-pass-submit']");

        public void EnterEmailReset(string p0)
        {
             driver.FindElement(emailReset).SendKeys("QATester@fake-box.com");
        }
        public void ClickResetButton()
        {
            driver.FindElement(resetBtn).Click();
        }

        public void SwitchToMailTab()
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open()");
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.Navigate().GoToUrl("https://www.trash-mail.com/inbox/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.CssSelector("#inputEmail")).SendKeys("QATester");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            SelectElement select = new SelectElement(driver.FindElement(By.XPath("//select[@id='form-domain-id']")));
            select.SelectByValue("fake-box.com---1");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.CssSelector("#inputPassword")).SendKeys("password1234");
            driver.FindElement(By.XPath("//button[@id='fetch-mails']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//a[normalize-space()='Inbox']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Navigate().Refresh();
            Random random = new Random();
            int indexNumb = random.Next(1,2);
            driver.FindElement(By.XPath("//*[@id='message-text-"+indexNumb+"']")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.FindElement(By.XPath("//a[contains(text(),'https://mentorskid.com/reset-password/?somresetpas')]")).Click();
        }
        public void EnterNewPassword(string p0)
        {
            driver.FindElement(newPassword).SendKeys("1234password");
        }
        public void EnterNewPasswordAgain(string p0)
        {
            driver.FindElement(newPassword2).SendKeys("1234password");
        }
        public void ClickResetPasswordButton()
        {
            driver.FindElement(newPasswordResetBtn).Click();
        }

                
    }

}
    
