
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationTask.Common.POM_Elements.AutomationPractice
{
   public class SignInPage
    {
        private IWebDriver driver;
        public SignInPage(IWebDriver _driver)
        {
            driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id,Using = "SubmitCreate")]
        public IWebElement CreateAnAccountButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='create_account_error']/ol/li")]
        public IWebElement CreateAccountError { get; set; }

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        public IWebElement SignInButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/div[1]/ol/li")]
        public IWebElement SignInErrorMessage { get; set; }
        
        [FindsBy(How = How.Id, Using = "email_create")]
        public IWebElement EmailId_CreateTextbox { get; set; }
        
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailId_LogInTextbox { get; set; }

        [FindsBy(How = How.Name, Using = "id_gender")]
        public IWebElement GenderRadioButton { get; set; }

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        public IWebElement FirstNameTextbox { get; set; }

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        public IWebElement LastNameTextbox { get; set; }

        [FindsBy(How = How.Id, Using = "passwd")]
        public IWebElement PasswordTextbox { get; set; }
        
        [FindsBy(How = How.Id, Using = "firstname")]
        public IWebElement AddressFirstNameTextbox { get; set; }

        [FindsBy(How = How.Id, Using = "lastname")]
        public IWebElement AddressLastNameTextbox { get; set; }
      
        [FindsBy(How = How.Id, Using = "address1")]
        public IWebElement AddressTextbox { get; set; }
        
        [FindsBy(How = How.Id, Using = "city")]
        public IWebElement CityTextbox { get; set; }
        
        [FindsBy(How = How.Id, Using = "id_state")]
        public IWebElement StateDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "postcode")]
        public IWebElement PostcodeTextbox { get; set; }

        [FindsBy(How = How.Id, Using = "id_country")]
        public IWebElement CountryDropdown { get; set; }

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        public IWebElement MobilePhoneTextbox { get; set; }

        [FindsBy(How = How.Id, Using = "alias")]
        public IWebElement AddressAliasTextbox { get; set; }
        
        [FindsBy(How = How.Id, Using = "submitAccount")]
        public IWebElement RegisterButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div#center_column p")]
         public IWebElement SuccessMessage { get; set; }
    }
}
