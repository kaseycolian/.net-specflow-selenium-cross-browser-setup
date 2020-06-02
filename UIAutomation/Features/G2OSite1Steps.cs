using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using TechTalk.SpecFlow;
using UIAutomation.Drivers;

namespace UIAutomation.Tests
{
    [Binding]
    public class G2OSite1Steps
    {
        private readonly Driver _webDriver;
        private readonly ConfigurationDriver _configurationDriver;

 
        //public G2OSite1Steps(Driver webDriver, ConfigurationDriver configurationDriver)
        //{
        //    _webDriver = webDriver;
        //    _configurationDriver = configurationDriver;
        //}


        //[Given(@"The user has avigated to g(.*)o's website")]
        //public void GivenTheUserHasAvigatedToGoSWebsite(int p0)
        //{
        //   _webDriver.Current
        //        .Navigate().GoToUrl("https://www.g2o.com");
        //}

        //[When(@"the user has clicked (.*)")]
        //public void WhenTheUserHasClicked(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}

        //[Then(@"the new URL should contain '(.*)'")]
        //public void ThenTheNewURLShouldContain(string p0)
        //{
        //    ScenarioContext.Current.Pending();
        //}

    }
}
