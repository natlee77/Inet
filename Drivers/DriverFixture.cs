using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Inet.Drivers
{
    public class DriverFixture : IDisposable
    {
        private readonly IWebDriver webDriver;

        public DriverFixture()
        {
            webDriver = GetWebDriver();
        }

        public IWebDriver Driver => webDriver;

        public void Dispose()
        {
           Driver.Quit();
        }

        private IWebDriver GetWebDriver()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());       
            return new FirefoxDriver();
        }






    }
}
