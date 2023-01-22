using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using Inet.Drivers;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Firefox;

namespace Inet.Hooks
{
    [Binding]
    public sealed class HookFirefox
    {
        private readonly DriverFixture _driverHelper;
        public HookFirefox(DriverFixture driverHelper) => _driverHelper = driverHelper;

        [BeforeScenario]
        public static void BeforeScenario()
        {
           
            FirefoxOptions option = new FirefoxOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("--disable-gpu");
            //option.AddArguments("--headless");

             
            new DriverManager().SetUpDriver(new FirefoxConfig());
            Console.WriteLine("Setup");
           
            //_driverHelper.Driver = new FirefoxDriver(option);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Quit();
        }
    }
}
