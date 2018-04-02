using System;
using System.Collections.Generic;
using System.Threading;
using AutomationTask.SetUp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AutomationTask.StepDefinitons.AutomationPractice
{
    [Binding]
    public class HomePageSteps :TestSetup
    {
        //http://automationpractice.com/index.php

        [Given(@"I open AutomationPractice site")]
        public void GivenIOpenAutomationPracticeSite()
        {
            WebPortal.CommonActions.Navigate(Settings.Default.URL);
        }
        
        [Then(@"I am able to view the menu '(.*)' , '(.*)' and '(.*)'")]
        public void ThenIAmAbleToViewTheMenuAnd(string menu1, string menu2, string menu3)
        {
            bool flag = false;
            var lst4 = WebPortal.CommonActions.GetText(WebPortal.HomePage.HomePageMenu);
            string[] homePageMenu = { menu1, menu2, menu3 };
            AssertMenu(lst4, homePageMenu, flag);
        }

        private static void AssertMenu(string lst4, string[] homePageMenu, bool flag)
        {
            string[] splitCharacter = {"\r\n"};
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

        [Then(@"I am able to view the woman category '(.*)' and '(.*)'")]
        public void ThenIAmAbleToViewTheWomanCategoryAnd(string menu1, string menu2)
        {
            Thread.Sleep(5000);
            WebPortal.CommonActions.RefreshPage();
            bool flag = false;
            var lst4 = WebPortal.CommonActions.GetText(WebPortal.HomePage.WomanCategoryMenu);
            string[] homePageMenu = { menu1, menu2};
            AssertMenu(lst4, homePageMenu, flag);
        }

        [Then(@"I am able to view tooltip '(.*)' on '(.*)' menu")]
        [Then(@"I am able to view tooltip '(.*)' on '(.*)' button")]
        public void ThenIAmAbleToViewTooltipAs(string tooltipString, string tooltipAttribute)
        {
            IWebElement element = null;

            switch (tooltipAttribute)
            {
                case "WOMEN":element = WebPortal.HomePage.WomenMenu;
                    break;
                case "Contact us":element = WebPortal.ContactUsPage.ContactUs;
                    break;
                case "Dresses":element = WebPortal.HomePage.DressesMenu;
                    break;
                case "T-shirts":element = WebPortal.HomePage.TShirtsMenu;
                    break;
                case "Sign in":element = WebPortal.HomePage.HomePageSignInButton;
                    break;
                case "Cart":element = WebPortal.HomePage.CartButton;
                    break;
            }

            Assert.AreEqual(WebPortal.CommonActions.GetAttribute(element, "title"), tooltipString);
        }

        [Given(@"I mouse over on product '(.*)'")]
        [When(@"I mouse over on product '(.*)'")]
        public void WhenIMouseOverOnProduct(string productName)
        {
            WebPortal.CommonActions.MouseOver(WebPortal.HomePage.ProductMouseOver);
        }

        [Then(@"I am able to view '(.*)' and '(.*)' button on product '(.*)'")]
        public void ThenIAmAbleToViewAndButtonOnProduct(string menu1, string menu2, string productName)
        {
           // ScenarioContext.Current.Pending();
        }

    }
}
