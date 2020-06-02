using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UIAutomatedTests.Drivers;

namespace UIAutomatedTests.Features
{
    [Binding]
    public class GoogleSteps
    {
        private readonly WebDriver _webDriver;
        private readonly ConfigurationDriver _configurationDriver;

        public GoogleSteps(WebDriver webDriver, ConfigurationDriver configurationDriver)
        {
            _webDriver = webDriver;
            _configurationDriver = configurationDriver;
        }

        [Given(@"the user has navigated to google")]
        public void GivenTheUserHasNavigatedToGoogle()
        {
            _webDriver.SeleniumDriver.Navigate().GoToUrl("https://www.google.com");
        }

        [When(@"the user clicks on the '(.*)'")]
        public void WhenTheUserClicksOnTheMFeelingLucky(string p0)
        {
            var luckyButton = _webDriver.SeleniumDriver.FindElement(By.XPath(string.Format("//input[@value=\"{0}\"]", p0)));
            _webDriver.Click(luckyButton);
            _webDriver.Pause(15);
        }

        [Then(@"the url will not contain '(.*)'")]
        public void ThenTheUrlWillNotContain(string p0)
        {
            var currentUrl = _webDriver.SeleniumDriver.Url;
            currentUrl.Should().NotBeSameAs(p0).And.Contain(p0);
        }

        [When(@"the user enters '(.*)'m Feeling Lucky'")]
        public void WhenTheUserEntersMFeelingLucky(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"clicks search")]
        public void WhenClicksSearch()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the url will change and contain '(.*)'m Feeling Lucky'")]
        public void ThenTheUrlWillChangeAndContainMFeelingLucky(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
