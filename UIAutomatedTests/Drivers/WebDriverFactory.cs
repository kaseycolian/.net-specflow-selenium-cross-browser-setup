using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using TechTalk.SpecRun;

namespace UIAutomatedTests.Drivers
{
    public class WebDriverFactory
    {
        private readonly ConfigurationDriver _configurationDriver;
        private readonly TestRunContext _textRunContext;

        public WebDriverFactory(ConfigurationDriver configurationDriver, TestRunContext testRunContext)
        {
            _configurationDriver = configurationDriver;
            _textRunContext = testRunContext;
        }

        public IWebDriver GetBrowserDriver(string browserName)
        {
            var browserNameLower = browserName.ToLower();

            switch (browserNameLower)
            {
                case "chrome": return GetChromeDriver();
                case "ie": return GetIEDriver();

                default: throw new NotSupportedException($"Browser not supported: {browserName}");
            }
        }

        private IWebDriver GetIEDriver()
        {
            var ieDriver = new InternetExplorerDriver(InternetExplorerDriverService.CreateDefaultService(_textRunContext.TestDirectory));
            return ieDriver;
        }

        private IWebDriver GetChromeDriver()
        {
            var options = new ChromeOptions
            {
                AcceptInsecureCertificates = true
            };

            options.AddArguments("--start-maximized");

            var chromeDriver = new ChromeDriver(ChromeDriverService.CreateDefaultService(_textRunContext.TestDirectory), options);

            // Set base url directly on the driver?  Or create a driver method to set base URL, then add relative
            //chromeDriver.Url = _configurationDriver.BaseUrl;

            return chromeDriver;
        }
    }
}
