using MentorSkidSoftwareProject.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MentorSkidSoftwareProject.PageObject
{
    class MenteeBookingsAndPaymentPage
    {
        public IWebDriver driver;
        public MenteeBookingsAndPaymentPage()
        {
            driver = BaseTest.driver;
        }
       
        private By findMentor = By.CssSelector("a[href='https://mentorskid.com/find-instructors/']");
        private By viewProfile = By.XPath("//a[@href='https://mentorskid.com/instructor/olusegun-yakubu/'][normalize-space()='View Profile']");
        private By viewProfile2 = By.XPath("//a[@href='https://mentorskid.com/instructor/toluwalase-banjo/'][normalize-space()='View Profile']");
        private By bookTuition = By.CssSelector("#tu-book-appointment");
        private By slotChoice = By.XPath("(//*[@id='0900-1000']/label)[1]");
        private By saveContinue1 = By.CssSelector("#tu-next-addbook-step2");
        private By saveContinue2 = By.CssSelector("#tu-next-addbook-step3");
        private By proceedCheckout = By.CssSelector("#tu-next-addbook-checkout");
        private By cardNumber = By.XPath("//*[@id='Field-numberInput']");
        private By expiryDate = By.CssSelector("#Field-expiryInput");
        private By cvcNumber = By.CssSelector("#Field-cvcInput");
        private By placeOrder = By.CssSelector("#place_order");
        private By orderMessage = By.CssSelector(".tuturn-entry-title");
        private By failedSlot2 = By.XPath("/html/body/div[3]/div[2]/div//div[2]/span[2]");
        private By failedSlot = By.XPath("(//button[@type='button'])[5]");
        
        IWebElement startingDate => driver.FindElement(By.CssSelector("input[placeholder=' '][name='tu_start_date']"));
        IWebElement nextMonth => driver.FindElement(By.XPath("//body[1]/div[3]/div[1]/div[1]/div[1]/div[1]/button[2]"));
        IWebElement dayMonday => driver.FindElement(By.XPath("//div[@class='day-item'][normalize-space()='4']"));
        IWebElement endingDate => driver.FindElement(By.CssSelector("input[placeholder=' '][name='tu_end_date']"));
        IWebElement nextMonth2 => driver.FindElement(By.XPath("//body[1]/div[4]/div[1]/div[1]/div[1]/div[1]/button[2]"));
        IWebElement dayFriday => driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div/div/div[3]/div[12]"));
        IWebElement startingTime => driver.FindElement(By.CssSelector("#tu-start-time-filter"));
        IWebElement endingTime => driver.FindElement(By.CssSelector("#tu-end-time-filter"));
        IWebElement  selectMonday=> driver.FindElement(By.CssSelector("label[for='monday']"));
        IWebElement selectTuesday => driver.FindElement(By.CssSelector("label[for='tuesday']"));
        IWebElement selectThursday => driver.FindElement(By.CssSelector("label[for='thursday']"));
        IWebElement showAvailability => driver.FindElement(By.XPath("//a[@id='tu-filter-days-booking-slots']"));
        IWebElement billingFirstname => driver.FindElement(By.CssSelector("#billing_first_name"));
        IWebElement billingLastname => driver.FindElement(By.CssSelector("#billing_last_name"));
        IWebElement billingCompanyname => driver.FindElement(By.CssSelector("#billing_company"));
        IWebElement billingStreetname => driver.FindElement(By.CssSelector("#billing_address_1"));
        IWebElement billingTown => driver.FindElement(By.CssSelector("#billing_city"));
        IWebElement billingPostcode => driver.FindElement(By.CssSelector("#billing_postcode"));
        IWebElement billingPhone => driver.FindElement(By.CssSelector("#billing_phone"));
       
        public void UserFindAMentor()
        {
            Thread.Sleep(5000);
            driver.FindElement(findMentor).Click();
        }
        public void UserViewProfile()
        {
            Thread.Sleep(3000);
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.scrollBy(0,2200)");
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//a[normalize-space()='2']")).Click();

            Thread.Sleep(3000);
            IJavaScriptExecutor jse1 = (IJavaScriptExecutor)driver;
            jse1.ExecuteScript("window.scrollBy(0,2200)");
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//a[normalize-space()='3']")).Click();

            Thread.Sleep(3000);
            IJavaScriptExecutor jsep = (IJavaScriptExecutor)driver;
            jsep.ExecuteScript("window.scrollBy(0,2500)");
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//a[normalize-space()='4']")).Click();

            Thread.Sleep(5000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,800)");
            Thread.Sleep(3000);
            driver.FindElement(viewProfile).Click();
        }
       
        public void UserBookASession()
        {
            Thread.Sleep(3000);
            driver.FindElement(bookTuition).Click();
        }

        public void AllBookingDetailsFields()
        {
            Thread.Sleep(3000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,800)");
            startingDate.Click();

            IJavaScriptExecutor j = (IJavaScriptExecutor)driver;
            j.ExecuteScript("window.scrollBy(0,250)");
            Thread.Sleep(5000);
            nextMonth.Click();
            Thread.Sleep(5000);
            dayMonday.Click();

            IJavaScriptExecutor jsed = (IJavaScriptExecutor)driver;
            jsed.ExecuteScript("window.scrollBy(0,100)");
            Thread.Sleep(5000);
            endingDate.Click();
            Thread.Sleep(3000);
            nextMonth2.Click();
            Thread.Sleep(5000);
            dayFriday.Click();

            SelectElement selectStart = new SelectElement(startingTime);
            selectStart.SelectByValue("0800");
            Thread.Sleep(3000);
            SelectElement selectEnd = new SelectElement(endingTime);
            selectEnd.SelectByValue("1200");

            selectMonday.Click();
            selectTuesday.Click();
            selectThursday.Click();

        }

        public void ClickShowAvailabilityBtn()
        {
            Thread.Sleep(5000);
            showAvailability.Click();
        }

        public void UserSelectSlotChoice()
        {
            Thread.Sleep(3000);
            driver.FindElement(slotChoice).Click();
        }

        public void ClickSaveAndContinueBtn1()
        {
            driver.FindElement(saveContinue1).Click();
        }

        public void ClickSaveAndContinueBtn2()
        {
            Thread.Sleep(3000);
            driver.FindElement(saveContinue2).Click();
        }

        public void UserProceedToCheckout()
        {
            driver.FindElement(proceedCheckout).Click();
            Thread.Sleep(5000);
        }

        public void BillingDetails(string TesterAlpha)
        {
            billingFirstname.Clear();
            billingFirstname.SendKeys("TesterAlpha");   
        }

        public void LastName(string TesterBeta)
        {
            Thread.Sleep(3000);
            billingLastname.Clear();
            billingLastname.SendKeys(TesterBeta);
        }
        public void CompanyName(string p0)
        {
            billingCompanyname.Clear();
            Thread.Sleep(3000);
            billingCompanyname.SendKeys("Alpha Beta Consulting");    
           
        }

        public void StreetName(string TesterAvenue)
        {
            Thread.Sleep(3000);
            billingStreetname.Clear();
            Thread.Sleep(2000);
            billingStreetname.SendKeys("Tester Avenue");
        }

        public void TownOrCity(string p0)
        {
            Thread.Sleep(3000);
            billingTown.Clear();
            Thread.Sleep(2000);
            billingTown.SendKeys("Tester City");
        }

        public void PostCode(string p0)
        {
            Thread.Sleep(3000);
            billingPostcode.Clear();
            Thread.Sleep(2000);
            billingPostcode.SendKeys("BH11 2AA");
        }

        public void PhoneNumber(string args)
        {
            Thread.Sleep(3000);
            billingPhone.Clear();
            string numString = "07102030405";
            Int64 num = Convert.ToInt64(numString);
            billingPhone.SendKeys(numString);

        }

        public void TestCardNumber(string p0)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,2200)");
            driver.SwitchTo().ParentFrame();
            driver.SwitchTo().Frame(driver.FindElement(By.CssSelector("iframe[title='Secure payment input frame']")));
            driver.FindElement(cardNumber).SendKeys("4242424242424242");
            driver.SwitchTo().DefaultContent();
        }

        public void TestCardExpiryDate(string p0)
        {
            driver.SwitchTo().ParentFrame();
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//*[@id='wc-woocommerce_payments-upe-form']/div[1]/div/iframe")));
            driver.FindElement(expiryDate).SendKeys("1227");
            driver.SwitchTo().DefaultContent();
        }
        public void TestCardCVC(string p0)
        {
            driver.SwitchTo().ParentFrame();
            driver.SwitchTo().Frame(driver.FindElement(By.CssSelector("iframe[title='Secure payment input frame']")));
            driver.FindElement(cvcNumber).SendKeys("321");
            driver.SwitchTo().DefaultContent();
        }
        public void UserPlacOrder()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,2300)");
            Thread.Sleep(4000);
            driver.FindElement(placeOrder).Click();
        }

        public string OrderedConfirmationMessage()
        {
            Thread.Sleep(5000);
            return driver.FindElement(orderMessage).Text;
        }

        public void UnavailableMentorView()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//a[@href='https://mentorskid.com/instructor/kira-joy/'][normalize-space()='View Profile']")).Click();
        }

        public void NoSlotsAvailable()
        {
            Thread.Sleep(2000);
            driver.FindElement(failedSlot).Click();
        }

    }
}
