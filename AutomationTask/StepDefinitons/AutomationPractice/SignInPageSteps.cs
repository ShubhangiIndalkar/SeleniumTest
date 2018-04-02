using System;
using System.Threading;
using AutomationTask.Common.Utils;
using AutomationTask.SetUp;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace AutomationTask.StepDefinitons.AutomationPractice
{
    [Binding]
    public class SignInPageSteps:TestSetup
    {
        [Then(@"I am able to view successful message '(.*)' for creating account")]
        public void ThenIAmAbleToViewSuccessfulMessageForCreatingAccount(string successMessage)
        {
            Assert.AreEqual(WebPortal.CommonActions.GetText(WebPortal.SignInPage.SuccessMessage),successMessage);
        }

        [Given(@"I read the excel file '(.*)'")]
        public void GivenIReadTheExcelFile(string excelFileName)
        {
            ExcelLib.PopulateInCollection(@"G:\AutomationTask\" + excelFileName);
        }

        [Given(@"I fill the form with data from excel")]
        public void GivenIFillTheFormWithDataFromExcel()
        {
            Thread.Sleep(3000);
            WebPortal.CommonActions.EnterText(WebPortal.SignInPage.FirstNameTextbox, ExcelLib.ReadData(1, "First Name"));
            WebPortal.CommonActions.EnterText(WebPortal.SignInPage.LastNameTextbox, ExcelLib.ReadData(1, "Last Name"));
            WebPortal.CommonActions.EnterText(WebPortal.SignInPage.PasswordTextbox, ExcelLib.ReadData(1, "Password"));
            WebPortal.CommonActions.EnterText(WebPortal.SignInPage.AddressFirstNameTextbox, ExcelLib.ReadData(1, "Address of First Name"));
            WebPortal.CommonActions.EnterText(WebPortal.SignInPage.AddressLastNameTextbox, ExcelLib.ReadData(1, "Address of Last Name"));
            WebPortal.CommonActions.EnterText(WebPortal.SignInPage.AddressTextbox, ExcelLib.ReadData(1, "Address"));
            WebPortal.CommonActions.EnterText(WebPortal.SignInPage.CityTextbox, ExcelLib.ReadData(1, "City"));
            WebPortal.CommonActions.EnterText(WebPortal.SignInPage.StateDropdown, ExcelLib.ReadData(1, "State"));
            WebPortal.CommonActions.EnterText(WebPortal.SignInPage.PostcodeTextbox, ExcelLib.ReadData(1, "Post code"));
            WebPortal.CommonActions.EnterText(WebPortal.SignInPage.CountryDropdown, ExcelLib.ReadData(1, "Country"));
            WebPortal.CommonActions.EnterText(WebPortal.SignInPage.MobilePhoneTextbox, ExcelLib.ReadData(1, "Mobile Number"));
            WebPortal.CommonActions.ClearText(WebPortal.SignInPage.AddressAliasTextbox);
            WebPortal.CommonActions.EnterText(WebPortal.SignInPage.AddressAliasTextbox, ExcelLib.ReadData(1, "Alias Address"));
        }

    }
}
