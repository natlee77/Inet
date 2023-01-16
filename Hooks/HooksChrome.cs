using OpenQA.Selenium.Chrome;
using Inet.Drivers;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;


namespace Inet.Hooks
{
    [Binding]
    public sealed class HooksChrome
    {
        private readonly DriverHelper _driverHelper;
        public HooksChrome(DriverHelper driverHelper) => _driverHelper = driverHelper;

        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("--disable-gpu");
            //option.AddArguments("--headless");

            new DriverManager().SetUpDriver(new ChromeConfig());
            Console.WriteLine("Setup");
            _driverHelper.Driver = new ChromeDriver(option);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Quit();
        }
    }
}
