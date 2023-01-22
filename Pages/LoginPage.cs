using Inet.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inet.Pages
{
    public class LoginPage
    {
        private readonly DriverFixture driverFixture;


        public LoginPage(DriverFixture driverFixture)
        {
            this.driverFixture = driverFixture;
        }

        IWebElement txtUserName => driverFixture.Driver.FindElement(By.XPath("//input[@id='login.email']"));
        IWebElement txtPassword => driverFixture.Driver.FindElement(By.XPath("//input[@id='password']"));
        IWebElement btnLogin => driverFixture.Driver.FindElement(By.CssSelector("button[type='submit']"));


        public void EnterUserNameAndPassword(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtPassword.SendKeys(password);
        }

        public void ClickLogin()
        {
            btnLogin.Click();
        }
    }
}
