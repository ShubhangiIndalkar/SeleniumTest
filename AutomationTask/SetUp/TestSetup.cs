using AutomationTask.Common.Utils;
using TechTalk.SpecFlow;

namespace AutomationTask.SetUp
{
    [Binding]
    public class TestSetup
    {
        public static WebPortal WebPortal;

        [BeforeScenario]
        private void BeforeSetup()
        {
            if (WebPortal==null)
            {
                WebPortal=new WebPortal(Settings.Default.Browser);
            }
        }

        [AfterScenario]
        private void AfterSetup()
        {
          WebPortal.CommonActions.DisposeDriver();
          WebPortal = null;
        }
    }
}
