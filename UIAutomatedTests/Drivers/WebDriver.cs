using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace UIAutomatedTests.Drivers
{
    public class WebDriver
    {
        private readonly Driver _webDriver;
        private readonly ConfigurationDriver _configurationDriver;

        public WebDriver(Driver webDriver, ConfigurationDriver configurationDriver)
        {
            this._webDriver = webDriver;
            _configurationDriver = configurationDriver;
        }

        public IWebDriver SeleniumDriver => _webDriver.Current;

        public void ExecuteClick(IWebElement element)
        {
            var executor = (IJavaScriptExecutor)_webDriver.Current;
            executor.ExecuteScript("arguments[0].click();", element);
        }

        public void ScrollTo(IWebElement element)
        {
            var executor = (IJavaScriptExecutor)_webDriver.Current;
            executor.ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        public void MoveTo(IWebElement element)
        {
            var action = new Actions(_webDriver.Current);
            action.MoveToElement(element).Perform();
        }

        //Fix this or switch to system thread 
        public void Pause(int seconds = 2)
        {
            var timesSpan = TimeSpan.FromSeconds(seconds);
            var wait = new WebDriverWait(_webDriver.Current, timesSpan);
        }

        public void WaitUntilPageComplete()
        {
            string state;

            do
            {
                state = (string)ExecuteScript("return document.readyState;");
            }
            while (state != "complete");
        }

        private object ExecuteScript(string script, IWebElement element = null)
        {
            var executor = (IJavaScriptExecutor)_webDriver.Current;
            if(element == null)
            {
                return executor.ExecuteScript(script);
            }
            else
            {
                return executor.ExecuteScript(script, element);
            }
        }
    }
}
