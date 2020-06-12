using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecRun;

namespace UIAutomation.Drivers
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

        public IWebDriver GetDriverForBrowser(string browserName)
        {
            var browserNameLower = browserName.ToLower();

            switch (browserNameLower)
            {
                case "chrome": return GetChromeDriver();

                default: throw new NotSupportedException($"Browser not supported: {browserName}");

            }
        }

        private IWebDriver GetChromeDriver()
        {
            var options = new ChromeOptions
            {
                AcceptInsecureCertificates = true
            };
            options.AddArguments("--start-fullscreen");
            options.AddArguments("--start-maximized");


            var chromeDriver = new ChromeDriver(ChromeDriverService.CreateDefaultService(_textRunContext.TestDirectory), options);
            chromeDriver.Url = _configurationDriver.BaseUrl;

            //return new ChromeDriver(ChromeDriverService.CreateDefaultService(_textRunContext.TestDirectory))
            //{
            //    Url = _configurationDriver.BaseUrl
            //};

            return chromeDriver;
        }
    }
}
