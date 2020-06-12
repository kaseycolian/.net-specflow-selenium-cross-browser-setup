using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutomation.Drivers
{
    // this will be where we add helper driver methods then use this class for step files
    public class WebDriver
    {
        private readonly Driver webDriver;
        private readonly ConfigurationDriver _configurationDriver;

        public WebDriver(Driver webDriver, ConfigurationDriver configurationDriver)
        {
            this.webDriver = webDriver;
            _configurationDriver = configurationDriver;
        }

        public IWebDriver SeleniumDriver => webDriver.Current;

        // JS click event here

    }
}
