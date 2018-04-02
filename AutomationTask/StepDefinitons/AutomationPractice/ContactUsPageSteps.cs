using System;
using AutomationTask.SetUp;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomationTask.StepDefinitons.AutomationPractice
{
    [Binding]
    public class ContactUsPageSteps :TestSetup
    {
       
        
        [Then(@"I am able to view the success message as '(.*)'")]
        public void ThenIAmAbleToViewTheSuccessMessageAs(string sucessMessage)
        {
            Assert.AreEqual((WebPortal.CommonActions.GetText(WebPortal.ContactUsPage.SucessMessage)), sucessMessage);
        }

        [Then(@"I am able to view the Home button to navigate Home page")]
        public void ThenIAmAbleToViewTheHomeButtonToNavigateHomePage()
        {
            Assert.IsTrue(WebPortal.CommonActions.IsDisplayed(WebPortal.ContactUsPage.HomeNavigationButton));
        }

        [Then(@"I am able to view the Comment as '(.*)' for '(.*)'")]
        public void ThenIAmAbleToViewTheCommentAs(string commentString,string subject)
        {
            IWebElement element = null;

            switch (subject)
            {
                case "Customer service":
                    element = WebPortal.ContactUsPage.CustomerServiceComment;
                    break;
                case "Webmaster":
                    element = WebPortal.ContactUsPage.WebmasterComment;
                    break;
            }

            Assert.AreEqual((WebPortal.CommonActions.GetText(element)), commentString);
        }

    }
}
