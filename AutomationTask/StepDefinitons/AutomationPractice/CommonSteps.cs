using System.Threading;
using AutomationTask.SetUp;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using AutomationTask;

namespace AutomationTask.StepDefinitons.AutomationPractice
{
    [Binding]
    public class CommonSteps:TestSetup
    {
      

        [Then(@"I am able to view the '(.*)' page")]
        public void ThenIAmAbleToViewThePage(string pageName)
        {
            switch (pageName)
            {
                case "Contact Us":pageName = "contact";
                    break;
                case "Sign in":pageName = "my-account";
                    break;
            }

            Assert.IsTrue((WebPortal.CommonActions.GetURL()).Contains(pageName));
        }
        
        [Then(@"I am able to view the Sign in page title as '(.*)'")]
        [Then(@"I am able to view the Contact Us page title as '(.*)'")]
        public void ThenIAmAbleToViewTheContactUsPageTitleAs(string pageTitle)
        {
            Assert.AreEqual(WebPortal.CommonActions.GetTitle(), pageTitle);
        }

        [Given(@"I click on '(.*)' button")]
        [When(@"I click on '(.*)' button")]
        [Given(@"I click on '(.*)'")]
        public void GivenIclickOn(string menuName)
        {
            IWebElement element = null;

            switch (menuName)
            {
                case "WOMEN":element = WebPortal.HomePage.WomenMenu;
                    break;
                case "Contact us":element = WebPortal.ContactUsPage.ContactUs;
                    break;
                case "Send":element = WebPortal.ContactUsPage.SendButton;
                    break;
                case "Sign in":element = WebPortal.HomePage.HomePageSignInButton;
                    break;
                case "Create an account":element = WebPortal.SignInPage.CreateAnAccountButton;
                    break;
                case "Sign in for already register user":element = WebPortal.SignInPage.SignInButton;
                    break;
                case "Register":element = WebPortal.SignInPage.RegisterButton;
                    break;
                case "Cart":element = WebPortal.HomePage.CartButton;
                    break;
                case "Add to cart":element = WebPortal.HomePage.CartButton;
                    break;
            }
            WebPortal.CommonActions.Click(element);
        }

        [When(@"I enter '(.*)' as '(.*)'")]
        [Given(@"I enter '(.*)' as '(.*)'")]
        public void GivenIenterAs(string textField, string enterText)
        {
            IWebElement element = null;

            
            switch (textField)
            {
                case "Email id"://Contact us Page
                    element = WebPortal.ContactUsPage.EmailTextbox;
                    break;
                case "Message"://Contact us Page
                    element = WebPortal.ContactUsPage.MessageTextAera;
                    break;
                case "Subject"://Contact us Page
                    element = WebPortal.ContactUsPage.SubjectDropDown;
                    break;
                case "email id"://Sign in Page-Create User
                    element = WebPortal.SignInPage.EmailId_CreateTextbox;
                    break;
                case "First Name"://Sign in Page
                    Thread.Sleep(3000);
                    element = WebPortal.SignInPage.FirstNameTextbox;
                    break;
                case "Last Name"://Sign in Page
                    element = WebPortal.SignInPage.LastNameTextbox;
                    break;
                case "Password"://Sign in Page
                    element = WebPortal.SignInPage.PasswordTextbox;
                  //  enterText = ExcelLib.ReadData(1, "Password");
                    break;
                case "Address of First Name"://Sign in Page
                    element = WebPortal.SignInPage.AddressFirstNameTextbox;
                    break;
                case "Address of Last Name"://Sign in Page
                    element = WebPortal.SignInPage.AddressLastNameTextbox;
                    break;
                case "Address"://Sign in Page
                    element = WebPortal.SignInPage.AddressTextbox;
                    break;
                case "City"://Sign in Page
                    element = WebPortal.SignInPage.CityTextbox;
                    break;
                case "Post code"://Sign in Page
                    element = WebPortal.SignInPage.PostcodeTextbox;
                    break;
                case "Mobile Number"://Sign in Page
                    element = WebPortal.SignInPage.MobilePhoneTextbox;
                    break;
                case "Alias Address"://Sign in Page
                    element = WebPortal.SignInPage.AddressAliasTextbox;
                    break;
                case "Email Id"://Sign in Page-For login
                  //  ExcelLib.PopulateInCollection(@"G:\AutomationTask\Test.xlsx");
                    element = WebPortal.SignInPage.EmailId_LogInTextbox;
                  //  enterText = ExcelLib.ReadData(1, "EmailId");
                    break;

            }
          
            WebPortal.CommonActions.EnterText(element, enterText);

        }

        [When(@"I select '(.*)' as '(.*)'")]
        [Given(@"I select '(.*)' as '(.*)'")]
        public void GivenISelectSubjectAs(string dropdownName,string selectText)
        {
            IWebElement element = null;

            switch (dropdownName)
            {
                case "Subject"://Contact us Page
                    element = WebPortal.ContactUsPage.SubjectDropDown;
                    break;
                case "State"://Sign in Page
                    element = WebPortal.SignInPage.StateDropdown;
                    break;
                case "Country"://Sign in Page
                    element = WebPortal.SignInPage.CountryDropdown;
                    break;
            }
            WebPortal.CommonActions.SelectDropdownUsingText(element, selectText);
        }

        [Then(@"I am able to view the Error message as '(.*)' on '(.*)' form")]
        [Then(@"I am able to view the Error message as '(.*)' on '(.*)' form of Sign in page")]
        [Then(@"I am able to view the Error message as '(.*)' on '(.*)' page")]
        public void ThenIAmAbleToViewTheErrorMessageAsOnPage(string errorMessage,string pageName)
        {
            IWebElement element = null;

            switch (pageName)
            {
                case "Contact us":element = WebPortal.ContactUsPage.ErrorMessage;
                    break;
                case "Create an account":Thread.Sleep(3000);
                    element = WebPortal.SignInPage.CreateAccountError;
                    break;
                case "Sign in":Thread.Sleep(3000);
                    element = WebPortal.SignInPage.SignInErrorMessage;
                    break;
            }

            Assert.AreEqual((WebPortal.CommonActions.GetText(element)), errorMessage);
        }

        [Given(@"I select radio button '(.*)' as '(.*)'")]
        public void GivenISelectRadioButtonAs(string radiobuttonName, string radioButtonText)
        {
            IWebElement element = null;

            switch (radiobuttonName)
            {
                case "title":Thread.Sleep(3000);
                    element = WebPortal.SignInPage.GenderRadioButton;
                    break;
            }

            radioButtonText = radioButtonText == "Mrs." ? "2" : "1";

            WebPortal.CommonActions.SelectRadioButtonById(element,radioButtonText);
        }

    }
}
