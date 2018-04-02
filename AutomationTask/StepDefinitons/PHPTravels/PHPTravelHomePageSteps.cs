using System;
using AutomationTask.SetUp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace AutomationTask.StepDefinitons.PHPTravels
{
    [Binding]
    public class PHPTravelHomePageSteps :TestSetup
    {
        //http://www.phptravels.net/

        [Given(@"I open PHP Travel site")]
        public void GivenIOpenPHPTravelSite()
        {
            WebPortal.CommonActions.Navigate(Settings.Default.URL);
        }

        private static void AssertMenu(string lst4, string[] homePageMenu, bool flag)
        {
            string[] splitCharacter = { "\r\n" };
            string[] splitString = lst4.Split(splitCharacter, StringSplitOptions.None);
            for (int i = 0; i < splitString.Length; i++)
            {
                if (splitString[i] == homePageMenu[i])
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            Assert.IsTrue(flag);
        }
    }
}
