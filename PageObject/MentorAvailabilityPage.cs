using MentorSkidSoftwareProject.Hooks;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MentorSkidSoftwareProject.PageObject
{
    public class MentorAvailabilityPage
    {
        public IWebDriver driver = BaseTest.driver;
        public MentorAvailabilityPage()
        {
            driver = BaseTest.driver;
        }

        private By myCalendar = By.XPath("//*[@id='bookings-tab']");
        private By addBookings = By.LinkText("Add/Edit bookings");
        private By timeSlots = By.CssSelector("#tu-timeslot-tab");
        private By newtimeSlots = By.CssSelector(".tu-newslots.tu-add-appointment-timeslot");
        private By availableDays2 = By.CssSelector("#tu-add-timeslots>fieldset>div:nth-child(1)>div");
        private By slotTitle = By.XPath("//input[@placeholder='Slot title']");
        private By startTime = By.CssSelector("#start-time");
        private By endTime = By.CssSelector("#end-time");
        private By breakTime = By.CssSelector("#inter-duration");
        private By appointmentDuration = By.CssSelector("#apintment-duration");
        private By appointmentSpaces = By.ClassName("tu-apspaces");
        private By generateSlots = By.XPath("//a[@id='tu-generate-timeslots']");
        private By unavailableDays = By.XPath("//button[@id='tu-unavailable_dayslot-tab']");
        private By addUnavailabledays = By.XPath("//a[normalize-space()='Add unavailable days']");
        private By startEnd = By.CssSelector(".tu-placeholder");
        private By saveUpdate = By.XPath("//a[@id='tu-save-unavailable-days']");
        private By markdaysUnavailable = By.XPath("//a[@id='tu-generate-unavailable-days']");

        IWebElement successBookings => driver.FindElement(By.CssSelector("div[class='tu-boxsmtitle'] h4"));
        IWebElement dropDown => driver.FindElement(By.CssSelector("#tu-weekdays"));
        IList<IWebElement> dropDownOption => dropDown.FindElements(By.TagName("select"));      
        public void ClickMyCalendarButton()
        {
            Thread.Sleep(5000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(5000);
            driver.FindElement(myCalendar).Click();
        }

        public void ClickAddEditBookings()
        {
            driver.FindElement(addBookings).Click();
        }

        public void ClickAddTimeSlot()
        {
            driver.FindElement(timeSlots).Click();
        }

        public void AddNewTimeSlots()
        {
            driver.FindElement(newtimeSlots).Click();
        }
        
        public void SelectDaysFromList()
        {
            //USING MANUAL TESTING TECHNIQUES SUCH AS SENDKEYS AND KEYBOARD ENTER KEY
            driver.FindElement(By.XPath("//*[@id='tu-add-timeslots']/fieldset/div[1]/div/span/span[1]/span/ul")).Click();
            driver.FindElement(By.XPath("//*[@id='tu-add-timeslots']/fieldset/div[1]/div/span/span[1]/span/ul/li/input")).SendKeys("Monday");
            driver.FindElement(By.XPath("//*[@id='tu-add-timeslots']/fieldset/div[1]/div/span/span[1]/span/ul/li/input")).SendKeys(Keys.Enter);
            driver.FindElement(By.XPath("//*[@id='tu-add-timeslots']/fieldset/div[1]/div/span/span[1]/span/ul/li/input")).SendKeys(Keys.Enter);
        
            //ALTERNATIVE METHOD
            //driver.FindElement(By.XPath("//*[@id='tu-add-timeslots']/fieldset/div[1]/div/span/span[1]/span/ul")).Click();
            //Thread.Sleep(3000);
            //driver.FindElement(By.XPath("(//li[contains(@class,'select2-results')])[2]")).Click();
            //driver.FindElement(By.XPath("//*[@id='tu-add-timeslots']/fieldset/div[1]/div/span/span[1]/span/ul")).Click();

            //THE USE OF SELECT CLASS COULD NOT DISPLAY THE SELECTED ITEMS
             /*SelectElement selectDays = new SelectElement(driver.FindElement(By.XPath("//*[@id='tu-weekdays']")));
              selectDays.SelectByValue("sunday");
              Thread.Sleep(3000);
              selectDays.SelectByValue("wednesday");
              Thread.Sleep(5000); */

        }
       

        public void EntersSlotTitle(string p0)
        {
           driver.FindElement(slotTitle).SendKeys(p0);
           
        }

        public void SelectStartTime()
        {
            SelectElement select = new SelectElement(driver.FindElement(startTime));
            select.SelectByValue("0900");
            Thread.Sleep(3000);
        }
        public void SelectEndTime()
        {
            SelectElement select = new SelectElement(driver.FindElement(endTime));
            select.SelectByValue("1700");
            Thread.Sleep(2000);
        }
        public void SelectBreakTime ()
        {   
            SelectElement select = new SelectElement(driver.FindElement(breakTime));
            select.SelectByValue("60");
            Thread.Sleep(2000);
        }

        public void ClickSessionDuration()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,1500)");
            SelectElement select = new SelectElement(driver.FindElement(appointmentDuration));
            select.SelectByValue("420");
            Thread.Sleep(2000);
        }

        public void RandomSelectAppointmentSpaces()
        {
            Random random = new Random();
            int index = random.Next(1,4);
            driver.FindElement(By.XPath("//div[@class='form-group']//div["+index+"]")).Click();
        }

        public void GenerateTimeSlot()
        {   
            Thread.Sleep(5000);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollBy(0,800)");
            driver.FindElement(generateSlots).Click();
        }

        public string BookingsSuccessMessage()
        {
            return successBookings.Text;
        }

        public void clickUnavailabilityDay1()
        {
            driver.FindElement(unavailableDays).Click();
        }

        public void AddUnavailabilityDays2()
        {
            driver.FindElement(addUnavailabledays).Click();
        }
        public void StartAndEndDates()
        {
            driver.FindElement(By.XPath("//input[@type='text']")).Click();
            SelectElement select = new SelectElement (driver.FindElement(By.XPath("//select[@class='month-item-name']"))); // To select unavailability days for the month of Sept
            select.SelectByValue("8");
            driver.FindElement(By.XPath("//div[normalize-space()='9']")).Click(); //date 4th of sept
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[normalize-space()='10']")).Click(); // date 10th of sept
        }

        public void MarkSelectedDaysUnavailable()
        {
            driver.FindElement(markdaysUnavailable).Click();
        }
        public void SaveAndUpdateChanges()
        {
            Thread.Sleep(3000);
            driver.FindElement(saveUpdate).Click();
        }

        public bool UnavailableDateRegistered()
        {
            return driver.Url.Contains("https://mentorskid.com/profile-settings/?useridentity=351&tab=bookings");
        }

    }
}
