using TechTalk.SpecFlow;
using UIAutomatedTests.Drivers;

namespace UIAutomatedTests.Hooks
{
    [Binding]
    class TeardownHooks
    {

        private readonly Driver _webDriver;
        public TeardownHooks(Driver webDriver)
        {
            _webDriver = webDriver;
        }

        [AfterScenario(Order = 0)]
        public void KillBrowserDrivers()
        {
            _webDriver.Dispose();
        }

    }
}
