using Sauce_TestAutomationFramework.Lib;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AP_TestAutomationFramework.Tests
{
    public class Tests
    {
        private Sauce_Website<ChromeDriver> Sauce_Website = new();



        [OneTimeTearDown]
        public void CleanUp()
        {
            Sauce_Website.SeleniumDriver.Quit();
            Sauce_Website.SeleniumDriver.Dispose();
        }
    }
}