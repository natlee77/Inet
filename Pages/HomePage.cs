using Inet.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inet.Pages
{
    class HomePage
    {
        private readonly DriverFixture driverFixture;


        public HomePage(DriverFixture driverFixture)
        {
            this.driverFixture = driverFixture;
        }

        IWebElement lnkLogin => driverFixture.Driver.FindElement(By.CssSelector("button[data-test-id='my_page_button'] label[class='lnp1qmo']")); //label[normalize-space()='Min sida']

        IWebElement lnkLogOff => driverFixture.Driver.FindElement(By.CssSelector("button[type='button'] span[class='name']")); ////span[normalize-space()='Logga ut']


        public void ClickLogin() => lnkLogin.Click();

        public bool IsLogOffExist() => lnkLogOff.Displayed;
    }
}
