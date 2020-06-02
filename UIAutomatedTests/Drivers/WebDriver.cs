using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace UIAutomatedTests.Drivers
{
    // this will be where we add helper driver methods then use this class for step files
    public class WebDriver
    {
        private readonly Driver _webDriver;
        private readonly ConfigurationDriver _configurationDriver;
        public IWebDriver SeleniumDriver => _webDriver.Current;


        public WebDriver(Driver webDriver, ConfigurationDriver configurationDriver)
        {
            this._webDriver = webDriver;
            _configurationDriver = configurationDriver;
        }

        // JS click event here
        public void Click(IWebElement element)
        {
            var executor = (IJavaScriptExecutor)_webDriver.Current;
            executor.ExecuteScript("arguments[0].click();", element);
        }

        public void Pause(int seconds = 2)
        {
            var timesSpan = TimeSpan.FromSeconds(seconds);
            var wait = new WebDriverWait(_webDriver.Current, timesSpan);
        }
    }
}
