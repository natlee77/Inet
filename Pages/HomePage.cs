using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inet.Pages
{
    class HomePage
    {
        private readonly IWebDriver Driver;

        public HomePage(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement lnkLogin => Driver.FindElement(By.LinkText("Min sida"));

        IWebElement lnkLogOff => Driver.FindElement(By.LinkText("Logga ut"));

        public void ClickLogin() => lnkLogin.Click();

        public bool IsLogOffExist() => lnkLogOff.Displayed;
    }
}
