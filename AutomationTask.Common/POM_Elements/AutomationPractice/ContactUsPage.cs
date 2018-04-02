
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace AutomationTask.Common.POM_Elements.AutomationPractice
{
    public class ContactUsPage
    {
        private IWebDriver driver;

        public ContactUsPage(IWebDriver _driver)
        {
            driver = _driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "div#contact-link a")]
        public IWebElement ContactUs { get; set; }
        
        [FindsBy(How = How.Id, Using = "submitMessage")]
        public IWebElement SendButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div#center_column div ol li")]
        public IWebElement ErrorMessage { get; set; }
        
        [FindsBy(How = How.Id, Using = "email")]
        public IWebElement EmailTextbox { get; set; }

        [FindsBy(How = How.Id, Using = "message")]
        public IWebElement MessageTextAera { get; set; }
        
        [FindsBy(How = How.Id, Using = "id_contact")]
        public IWebElement SubjectDropDown { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div#center_column p")]
        public IWebElement SucessMessage { get; set; }
        
        [FindsBy(How = How.CssSelector, Using = "div#center_column ul li a span")]
        public IWebElement HomeNavigationButton { get; set; }

        [FindsBy(How = How.Id, Using = "desc_contact2")]
        public IWebElement CustomerServiceComment { get; set; }

        [FindsBy(How = How.Id, Using = "desc_contact1")]
        public IWebElement WebmasterComment { get; set; }
    }
}
