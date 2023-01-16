using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inet.Pages
{
    public class LoginPage
    {
        private IWebDriver Driver;

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement txtUserName => Driver.FindElement(By.XPath("//input[@id='login.email']"));
        IWebElement txtPassword => Driver.FindElement(By.XPath("//input[@id='password']"));
        IWebElement btnLogin => Driver.FindElement(By.CssSelector("button[type='submit']"));


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
