using NUnit.Framework;
using Inet.Pages;
using Inet.Drivers;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using System.Data;

namespace Inet.StepDefinitions
{

    [Binding]
    public sealed class LoginStepDefinitions
    {

        private readonly DriverFixture _driverHelper;
        private readonly   HomePage  homePage;
        private readonly   LoginPage loginPage;

        public LoginStepDefinitions(DriverFixture driverHelper, HomePage homePage, LoginPage loginPage)
        {
            this._driverHelper = driverHelper;
            this.homePage = new HomePage(driverHelper);
            this.loginPage = new LoginPage(driverHelper);
        }

       


        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            _driverHelper.Driver.Navigate().GoToUrl("http://inet.se/");
        }

        [Given(@"I click the Login link")]
        public void GivenIClickTheLoginLink()
        {
            homePage.ClickLogin();
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.EnterUserNameAndPassword(data.UserName, data.Password);
            foreach (var item in data)
            {
                Console.WriteLine($"The user info: {item.ToString()}");
            }
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            loginPage.ClickLogin();
        }

        [Then(@"I should see user logged in to the application")]
        public void ThenIShouldSeeUserLoggedInToTheApplication()
        {
            Assert.That(homePage.IsLogOffExist(), Is.True, "Log off button did not displayed");
        }

        

        

    }
}
